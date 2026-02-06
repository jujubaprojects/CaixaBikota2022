using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa.Cadastro;
using Caixa.Caixa;
using Caixa.Estoque;
using Caixa.Pagamentos;
using Caixa.Pedidos;
using Caixa.Reports;
using Componentes;
using dal;
using Npgsql;
using OpenQA.Selenium.BiDi.Input;
using Org.BouncyCastle.Asn1.X509;

namespace Caixa
{
    public partial class frmMenu : FormJCS
    {
        int iRetorno = 0;
        private SQL.SQL auxSQL = new SQL.SQL();
        private SqlConnection conn;
        private SqlTransaction transacao;
        private dal.Conexao conexao = new dal.Conexao();
        private int pedidoID = 0;
        private bool acessarFrmSenha = false;
        private static System.Timers.Timer timer45S;


        public frmMenu()
        {
            InitializeComponent();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, DATA, REPETIR, STATUS ");
            sql.Append("FROM LEMBRETE ");
            sql.Append("WHERE STATUS = 1 ");
            sql.Append("AND( ");
            //sql.Append("--Caso seja diário ");
            sql.Append("REPETIR = 1 ");
            //sql.Append("-- Caso seja semanal e o dia da semana seja o mesmo da data original ");
            sql.Append("OR(REPETIR = 2 AND DATEPART(WEEKDAY, DATA) = DATEPART(WEEKDAY, GETDATE())) ");
            //sql.Append("-- Caso seja quinzenal e a diferença em dias seja múltipla de 14 ");
            sql.Append("OR(REPETIR = 3 AND DATEDIFF(DAY, DATA, GETDATE()) % 14 = 0) ");
            //sql.Append("-- Caso seja mensal e o dia do mês seja o mesmo da data original ");
            sql.Append("OR(REPETIR = 4 AND DAY(DATA) = DAY(GETDATE())) ");
            //sql.Append("-- Caso seja anual e o dia e mês sejam os mesmos da data original ");
            sql.Append("OR(REPETIR = 5 AND FORMAT(DATA, 'MM-dd') = FORMAT(GETDATE(), 'MM-dd')) ");
            //caso seja uma unica vez.
            sql.Append("OR (REPETIR = 9 AND DATA = CAST(GETDATE() AS DATE)) ");
            sql.Append(") ");


            //EXECUTAR PROCEDURE PARA FOLGA
            DataTable dtLembrete = auxSQL.retornaDataTable(sql.ToString());
            if (dtLembrete.Rows.Count > 0)
            {
                string msgLembrete = "";
                for (int i = 0; i < dtLembrete.Rows.Count; i++)
                    msgLembrete += "\n" + dtLembrete.Rows[i]["DESCRICAO"].ToString() + " - " + dtLembrete.Rows[i]["DATA"].ToString();

                MessageBox.Show("Não se esqueça dos seguintes lembretes para hoje!" + msgLembrete, "Lembretes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (verificarImpressora())
            {
                Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));
                trd.IsBackground = true;
                trd.Start();
            }


            buscaPedidosAPIDelivery();//BUSCA PEDIDOS A CADA 45S

            frmPedidos frm = new frmPedidos();
            frm.MdiParent = this;
            frm.Show();

            verificaAgendamentos();
        }

        private void verificaAgendamentos (int pID = 0)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CONCAT(P.ID, ' - ' , P.DESCRICAO) DESCRICAO, TP.DESCRICAO TIPO,  AP.ID ID_AGENDAMENTO, FORMAT(AP.DT_AGENDAMENTO, 'dd/MM/yyyy HH:mm:ss') DT_AGENDAMENTO ");
            sql.Append("FROM PEDIDO P ");
            sql.Append("JOIN AGENDAMENTO_PEDIDO AP ON(P.ID = AP.PEDIDO) ");
            sql.Append("JOIN TIPO_PEDIDO TP ON (TP.ID = P.TIPO) ");
            sql.Append("WHERE AP.LEMBRETE_CRIADO = 0 AND P.SITUACAO != 0 AND CAST(AP.DT_AGENDAMENTO AS DATE) = CAST(GETDATE() AS DATE) ");
            DataTable dt = auxSQL.retornaDataTable(sql.ToString());
            if (dt.Rows.Count > 0)
            {
                string descricaoPedido;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    descricaoPedido = "LEMBRETE PEDIDO PARA HOJE " + dt.Rows[i]["DESCRICAO"].ToString() + " TIPO: " + dt.Rows[i]["TIPO"].ToString() + " - " + dt.Rows[i]["DT_AGENDAMENTO"].ToString();
                    auxSQL.insertPedido(descricaoPedido, dt.Rows[i]["TIPO"].ToString(), 1);
                    auxSQL.executaQuerySemRetorno("UPDATE AGENDAMENTO_PEDIDO SET LEMBRETE_CRIADO = 1 WHERE ID = " + dt.Rows[i]["ID_AGENDAMENTO"].ToString());
                        }
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            var normalized = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }


        private static void buscaPedidosAPIDelivery()
        {
            timer45S = new System.Timers.Timer(45000); // 45 segundos

            timer45S.Elapsed += async (s, e) =>
            {
                timer45S.Stop(); // Evita duas execuções simultâneas

                try
                {
                    //Console.WriteLine(">> Iniciando tarefa de 45 segundos...");
                    new PedidosAPI();
                    //Console.WriteLine(">> Tarefa de 45 segundos concluída!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na tarefa de Pedidos Delivery: " + ex.Message);
                }
                finally
                {
                    timer45S.Start();
                }
            };

            timer45S.Start();
        }


        private Boolean verificarImpressora()
        {
            string mensagemErro = "";
            iRetorno = MP2032.ConfiguraModeloImpressora(7);//CONFIGURA IMPRESSORA MODELO 4200            
            if (iRetorno <= 0)
                mensagemErro = "Impressora não configurada!!!";

            iRetorno = MP2032.IniciaPorta("192.168.0.50"); //inicia a porta com o IP digitado
            //iRetorno = MP2032.IniciaPorta("COM3"); //inicia a porta com o IP digitado
            if (iRetorno <= 0)
                mensagemErro = "Impressora não conectada!!!";

            //MP2032.

            iRetorno = MP2032.VerificaPapelPresenter();
            if (iRetorno > 0)
                mensagemErro = "Impressora sem papel!!!";

            if (!string.IsNullOrEmpty(mensagemErro))
            {
                MessageBox.Show(mensagemErro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void ThreadTarefa()
        {
            while (true)
            {
                DataTable dt = auxSQL.retornaPedidosImprimir();
                DataTable dtAdds;
                StringBuilder sImpressao = new StringBuilder();
                int indexAux;
                double valor = 0, vlTotal = 0;
                string descricao, observacao, observacaoPed = "", endereco = "", cobertura;
                string auxDescPedido = "", agendamento = "";
                int tipo = 0;


                if (dt.Rows.Count > 0)
                {
                    if (verificarImpressora())
                    {
                        Thread.Sleep(1000);
                        conn = conexao.retornaConexao();
                        transacao = conexao.startTransaction(conn);

                        StringBuilder sql = new StringBuilder();
                        sql.Append("UPDATE PEDIDO_PRODUTO SET SITUACAO = @situacao WHERE ID = @pedProdID");


                        try
                        {
                            auxDescPedido = dt.Rows[0]["DESC_PEDIDO"].ToString();
                            sImpressao.Append("Desc. Ped.: " + dt.Rows[0]["DESC_PEDIDO"].ToString() + "\r\n\r\n");
                            sImpressao.Append("ORDEM      PRODUTO" + "\r\n");
                            agendamento = dt.Rows[0]["AGENDAMENTO"].ToString();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                //if (!auxDescPedido.Equals(dt.Rows[i]["DESC_PEDIDO"].ToString()))
                                //{
                                //    auxDescPedido = dt.Rows[i]["DESC_PEDIDO"].ToString();
                                //    sImpressao.Append("Desc. Ped.: " + auxDescPedido + "\r\n\r\n");
                                //}

                                cobertura = "";
                                observacao = dt.Rows[i]["OBS_PRODUTO"].ToString();
                                descricao = dt.Rows[i]["DESC_PRODUTO"].ToString();
                                sImpressao.Append((i + 1).ToString("00") + "  -      QT. " + dt.Rows[i]["QT_PRODUTO"].ToString() + "  -  " + dt.Rows[i]["PRODUTO"].ToString() + "\r\n");
                                observacaoPed = dt.Rows[i]["OBS_PED"].ToString();
                                endereco = dt.Rows[i]["ENDERECO"].ToString();
                                tipo = int.Parse(dt.Rows[i]["TIPO"].ToString());


                                //sImpressao.Append("   " + dt.Rows[");");
                                if (!string.IsNullOrEmpty(descricao))
                                {
                                    if (descricao.Contains("COB.:"))
                                    {
                                        indexAux = descricao.IndexOf("COB.:");
                                        cobertura = descricao.Substring(indexAux);
                                        descricao = descricao.Substring(0, descricao.Length - cobertura.Length);
                                    }

                                    if (!string.IsNullOrEmpty(descricao.Trim()))
                                        sImpressao.Append("           " + RemoverAcentos(descricao) + "\r\n");

                                    if (!string.IsNullOrEmpty(cobertura))
                                        sImpressao.Append("           " + cobertura + "\r\n");
                                }

                                if (!string.IsNullOrEmpty(observacao))
                                    sImpressao.Append("           OBS.: " + RemoverAcentos(observacao) + "\r\n");


                                dtAdds = auxSQL.retornaPedidosAdds(int.Parse(dt.Rows[i]["PED_PROD_ID"].ToString()));
                                valor = double.Parse(dt.Rows[i]["VL_TOTAL"].ToString());
                                for (int j = 0; j < dtAdds.Rows.Count; j++)
                                {
                                    valor += double.Parse(dtAdds.Rows[j]["VALOR"].ToString());
                                    if (!string.IsNullOrEmpty(dtAdds.Rows[j]["DESCRICAO"].ToString()))
                                        sImpressao.Append("Adicional: " + dtAdds.Rows[j]["QT_PRODUTO"].ToString() + "x " + dtAdds.Rows[j]["PRODUTO"].ToString() + " - " + RemoverAcentos(dtAdds.Rows[j]["DESCRICAO"].ToString()));
                                    else
                                        sImpressao.Append("Adicional: " + dtAdds.Rows[j]["QT_PRODUTO"].ToString() + "x " + dtAdds.Rows[j]["PRODUTO"].ToString());
                                    sImpressao.Append("\r\n");
                                }
                                vlTotal += valor;
                                sImpressao.Append("Valor: " + valor + "\r\n");
                                sImpressao.Append("------------------------------------------------" + "\r\n");



                                SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                                sqlc.CommandType = CommandType.Text;
                                sqlc.Parameters.AddWithValue("@pedProdID", int.Parse(dt.Rows[i]["PED_PROD_ID"].ToString()));
                                sqlc.Parameters.AddWithValue("@situacao", 2);
                                auxSQL.executaQueryTransaction(conn, sqlc); //DESCOMENTAR DEPOIS
                            }

                            if (tipo == 3)
                            {
                                sImpressao.Append("ENDEREÇO: " + RemoverAcentos(endereco) + "\r\n");
                                if (!string.IsNullOrEmpty(observacaoPed))
                                    sImpressao.Append("OBSERVAÇÃO: " + RemoverAcentos(observacaoPed) + "\r\n");
                            }
                            if (tipo == 2)
                            {
                                sImpressao.Append("*********************LEVAR*********************" + "\r\n");
                            }

                            if (!string.IsNullOrEmpty(agendamento))
                                sImpressao.Append("**"+ agendamento + "**" + "\r\n");

                            sImpressao.Append("VALOR TOTAL:" + vlTotal + "\r\n");

                            sImpressao.Append("PAGAMENTO SOMENTE NO CAIXA!!!" + "\r\n");
                            sImpressao.Append("\r\n\r\n\r\n");
                            //iRetorno = MP2032.FormataTX(sImpressao + "\r\n\r\n", 1, 1, 0, 0, 0);
                            
                            //if (auxSQL.retornaDataTable("SELECT * FROM AGENDAMENTO_PEDIDO WHERE PEDIDO = " + pedidoID)
                            //{

                            //}

                            iRetorno = MP2032.ImprimeBitmap("C:\\Impressora\\Logo\\BikotaBmp24.bmp", 0);
                            if (iRetorno <= 0)
                            {
                                MessageBox.Show("Problema ao imprimir, verifique se a impressora está ligada!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                iRetorno = MP2032.AcionaGuilhotina(0); //chama a função da DLL (Corte Parcial)
                                return;
                            }

                            iRetorno = MP2032.BematechTX("\r" + sImpressao.ToString());//ao ser clicado, imprime o texto da Text Box
                                                                                       //iRetorno = MP2032.FormataTX("\r" + sImpressao.ToString(),1,1,1,1,1);//ao ser clicado, imprime o texto da Text Box
                            if (iRetorno <= 0)
                            {
                                MessageBox.Show("Problema ao imprimir, verifique se a impressora está ligada!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                iRetorno = MP2032.AcionaGuilhotina(0); //chama a função da DLL (Corte Parcial)
                                return;
                            }

                            iRetorno = MP2032.AcionaGuilhotina(0); //chama a função da DLL (Corte Parcial)
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                            transacao.Rollback();
                            conn.Close();
                            MessageBox.Show("Erro: " + e.InnerException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        finally
                        {
                            transacao.Commit();
                            conn.Close();
                        }
                    }


                }

                //verificaPesoInseriDBAutomatico();
                Thread.Sleep(1000);



            }
        }

        public void verificaPesoInseriDBAutomatico(int pPedidoProduto = 0)
        {

            /*CODIGO FUNCIONANDO ABAIXO */

            if (!PortaAberta && AbrePorta(CONSTANTES.porta, CONSTANTES.baudRate, CONSTANTES.dataBits, CONSTANTES.paridade) == 1)
            {
                //MessageBox.Show(this, "Porta aberta!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PortaAberta = true;
            }

            if (PortaAberta)
            {
                byte[] DadosPeso = new byte[6]; //5 bytes + nulo

                String caminho = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                if (PegaPeso(0, DadosPeso, caminho) == 1)
                {
                    double aux;

                    try
                    {
                        aux = double.Parse(ListaBytesParaString(DadosPeso));
                        aux = aux / 1000;
                    }
                    catch (Exception err)
                    {
                        //MessageBox.Show("Contate o suporte! \nErro: " + err.InnerException.Message);
                        PortaAberta = false;
                        return;
                    }

                    if (aux > 0.09)
                    {
                        //MessageBox.Show("Peso: " + ListaBytesParaString(DadosPeso));
                        PortaAberta = false;
                        auxSQL.insertPesoAutomatico(aux, pPedidoProduto);

                    }
                }
                //else
                //MessageBox.Show("Error!");
            }
            //else
            //MessageBox.Show(this, "Atenção! Porta fechada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void NovoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoPedido frm = new frmNovoPedido(1, 0);
            frm.ShowDialog();
        }

        private void PedidosAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.MdiParent = this;
            frm.Show();
            //frm.ShowDialog();
        }

        private void NovoPedidoRápidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoRapido frm = new frmPedidoRapido();
            frm.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o programa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void VendasPedidosDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmRelVendas frm = new frmRelVendas();
                frm.ShowDialog();
            }
        }

        private void ValorPorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                auxSQL.alteraSituacaoPedProdPago();
                frmRelVendasDia frm = new frmRelVendasDia();
                frm.ShowDialog();
            }
        }

        private bool acessoFrmsRestrito()
        {
            frmInputBoxJCS frm = new frmInputBoxJCS("Informe a senha.", 3, true);
            frm.ShowDialog();
            if (frm.retorno != "acessobikota")
            {
                MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void RecebimentoDeNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagarNota frm = new frmPagarNota();
            frm.ShowDialog();
        }

        private void RetiradaCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetiradaCaixa frm = new frmRetiradaCaixa();
            frm.ShowDialog();
        }

        private void BaldesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaldes frm = new frmBaldes();
            frm.ShowDialog();
        }

        private void RecebimentoRápidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoRapido frm = new frmPedidoRapido();
            frm.ShowDialog();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frm = new frmCadastroCliente();
            frm.ShowDialog();
        }

        private void BaldesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBaldes frm = new frmBaldes();
            frm.ShowDialog();
        }

        private void RecebimentoDeNotaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPagarNota frm = new frmPagarNota();
            frm.ShowDialog();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroEstoque frm = new frmCadastroEstoque();
                frm.ShowDialog();
            }
        }

        private void LinkEstoqueXProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (acessoFrmsRestrito())
            //{
            frmCadastroEstoque frm = new frmCadastroEstoque();
            frm.ShowDialog();
            //}
        }

        private void ProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroProduto frm = new frmCadastroProduto();
                frm.ShowDialog();
            }
        }

        private void ConsultarNotasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaNota frm = new frmConsultaNota();
            frm.ShowDialog();
        }

        private void ImportarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportXML frm = new frmImportXML();
            frm.ShowDialog();
        }

        private void NotasFiscaisEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");
            sql.Append("SELECT N.N_NF AS NF, F.NOME FORNECEDOR, P.COD_PROD CODIGO, P.DESC_PROD PRODUTO, QT_COM QT_COMPRADA, P.UN_COMERCIAL, VL_UNIT, N.DT_ENTREGA ");
            sql.Append("FROM NF N ");
            sql.Append("JOIN NF_PROD P ON(P.NF = N.ID) ");
            sql.Append("JOIN fornecedor F ON(N.FORNECEDOR = F.ID) ");
            //sql.Append("ORDER BY P.DESC_PROD, DT_ENTREGA DESC ");
            frmBusca frm = new frmBusca(sql, "Entradas de Notas Fiscais");
            frm.ShowDialog();
        }

        private void ProdutosParaComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            //{
            frmPedidoCompra frm = new frmPedidoCompra();
            frm.ShowDialog();
            //}
            //else
            //    MessageBox.Show("Esta opção só é permitida nas segundas-feiras!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LinkarEstoqueXProdutoXFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmLinkProdNFFornecedor frm = new frmLinkProdNFFornecedor();
                frm.ShowDialog();
            }
        }

        private void LinkProdutoNFXControleEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LinkarProdutoFinalXEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroSubEstoque frm = new frmCadastroSubEstoque();
                frm.ShowDialog();
            }
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frm = new frmCadastroFornecedor();
            frm.ShowDialog();
        }

        private void EstoqueBaldesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (acessoFrmsRestrito())
            //{
            frmEstoqueBalde frm = new frmEstoqueBalde("Estoque de Potes");
            frm.ShowDialog();
            //}
        }

        private void EstoqueDePotesDeSorvetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StringBuilder sql = new StringBuilder();
            //sql.Append("SELECT P.DESCRICAO PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE, DATA  ");
            //sql.Append("FROM ESTOQUE_POTE EP ");
            //sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
            //sql.Append("WHERE EP.QT_EST > 0 ");
            //sql.Append("ORDER BY 1, 2");
            //frmBusca frm = new frmBusca(sql, "Estoque de Potes de Sorvetes Prontos");
            //frm.ShowDialog();

            frmConsultaEstoquePotes frm = new frmConsultaEstoquePotes();
            frm.ShowDialog();

        }

        private void Sorvetes10lEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT REPLACE(dbo.RETORNA_SABORES(EP.ID), ';', '') DESCRICAO ");
            sql.Append("FROM ESTOQUE_POTE EP ");
            sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
            sql.Append("JOIN SABOR_ESTOQUE SE ON(SE.ID_EST_POTE = EP.ID) ");
            sql.Append("JOIN SABOR S ON(S.ID = SE.ID_SABOR) ");
            sql.Append("JOIN (SELECT SE.ID_EST_POTE, COUNT(ID_SABOR) QT_SABOR FROM SABOR_ESTOQUE SE GROUP BY SE.ID_EST_POTE) AUX ON(AUX.ID_EST_POTE = EP.ID) ");
            sql.Append("WHERE S.ATIVO = 1 AND P.TIPO = 4 AND P.DESCRICAO = 'POTE 10L' AND EP.QT_EST = 0 AND AUX.QT_SABOR = 1 ");
            sql.Append("ORDER BY DESCRICAO ");
            frmBusca frm = new frmBusca(sql, "Potes 10L Em Falta");
            frm.ShowDialog();
        }

        private void SubtrairEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubEstoque frm = new frmSubEstoque();
            frm.ShowDialog();
        }

        private void NFCupomManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroNFe frm = new frmCadastroNFe();
            frm.ShowDialog();
        }

        private void SubtrairEstoqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmSubEstoque frm = new frmSubEstoque();
            //frm.ShowDialog();

            if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 23)
            {
                frmSubEstoque frm = new frmSubEstoque();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Permitido utilizar esta tela apenas após as 20:00hrs. \n\nColoque a informação no grupo!!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






        [DllImport("P05.dll")] public static extern int AbrePorta(int Porta, int BaudRate, int DataBits, int Paridade);
        [DllImport("P05.dll")] public static extern int FechaPorta();
        [DllImport("P05.dll")] public static extern int FechaPortaP05();
        [DllImport("P05.dll")] public static extern int PegaPeso(int OpcaoEscrita, byte[] DadosPeso, string Local);
        [DllImport("P05.dll")] public static extern int PegaPesoP05B(int OpcaoEscrita, int PedeTara, byte[] DadosPeso, string Local);
        [DllImport("P05.dll")] public static extern void VersaoDLL(byte[] Versao);
        [DllImport("P05.dll")] public static extern int DeterminaUmStopBit();

        private static bool PortaAberta = false;

        private struct CONSTANTES
        {
            public const int porta = 9; //COM1
            public const int baudRate = 0; //2400
            public const int dataBits = 0; // 7 Bits
            public const int paridade = 2; //Par
            public const string ArquivoSinalizacao = "OK.TXT";
        }
        public static string ListaBytesParaString(byte[] lista)
        {
            char[] retornoChar = new char[lista.Length];
            for (int i = 0; i < lista.Length; i++)
                retornoChar[i] = (char)lista[i];
            string retorno = new string(retornoChar);
            return retorno;
        }

        private void ColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*CODIGO FUNCIONANDO ABAIXO*
            if (AbrePorta(CONSTANTES.porta, CONSTANTES.baudRate, CONSTANTES.dataBits, CONSTANTES.paridade) == 1)
            {
                MessageBox.Show(this, "Porta aberta!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                PortaAberta = true;
            }

            if (PortaAberta)
            {
                byte[] DadosPeso = new byte[6]; //5 bytes + nulo

                String caminho = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                if (PegaPeso(0, DadosPeso, caminho) == 1)
                    MessageBox.Show("Peso: " + ListaBytesParaString(DadosPeso));
                else
                    MessageBox.Show("Error!");
            }
            else
                MessageBox.Show(this, "Atenção! Porta fechada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            */


            //SerialPort mySerialPort = new SerialPort("COM9", 2400, Parity.None, 8, StopBits.One);
            //mySerialPort.Handshake = Handshake.None;
            //mySerialPort.WriteTimeout = 500;   
            ////PortChat.Porta();
            //try
            //{
            //    mySerialPort.Open();
            //    //String str = mySerialPort.ReadExisting();
            //    if (mySerialPort.BytesToRead > 0)
            //    {
            //        string str = mySerialPort.ReadLine();
            //        MessageBox.Show("Valor: " + str);
            //    }
            //    mySerialPort.Close();
            //}
            //catch (InvalidOperationException err)
            //{
            //    MessageBox.Show(err.InnerException.Message);
            //}
            //finally
            //{
            //    mySerialPort.Close();
            //}

        }

        private void PedidoParaFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelPedidoFornecedor frm = new frmRelPedidoFornecedor();
            frm.ShowDialog();
        }

        private void CadastroDeColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroColaborador frm = new frmCadastroColaborador();
                frm.ShowDialog();
            }
        }

        private void DespesasForaDoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmDespesa frm = new frmDespesa();
                frm.ShowDialog();
            }
        }

        private void InformaçõesRegistrosDeColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroOcorrenciaColaborador frm = new frmCadastroOcorrenciaColaborador();
                frm.ShowDialog();
            }
        }

        private void LembretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroLembrete frm = new frmCadastroLembrete();
            frm.ShowDialog();
        }

        private void AlertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAlerta frm = new frmCadastroAlerta();
            frm.ShowDialog();
        }

        private void BloqueioEstoqueManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acessoFrmsRestrito())
            {
                frmCadastroBloqueioEstoqueSubManual frm = new frmCadastroBloqueioEstoqueSubManual();
                frm.ShowDialog();
            }
        }

        private void TesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CODIGO FUNCIONANDO ABAIXO */
            try
            {
                if (!PortaAberta && AbrePorta(CONSTANTES.porta, CONSTANTES.baudRate, CONSTANTES.dataBits, CONSTANTES.paridade) == 1)
                {
                    MessageBox.Show(this, "Porta aberta!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PortaAberta = true;
                }

                if (PortaAberta)
                {
                    byte[] DadosPeso = new byte[6]; //5 bytes + nulo

                    String caminho = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                    if (PegaPeso(0, DadosPeso, caminho) == 1)
                    {
                        double aux = double.Parse(ListaBytesParaString(DadosPeso).Replace(",", "."));
                        if (aux > 0.09)
                        {
                            //MessageBox.Show("Peso: " + ListaBytesParaString(DadosPeso));
                            PortaAberta = false;
                            auxSQL.insertPesoAutomatico(aux);

                        }
                    }
                    else
                        MessageBox.Show("Error!");
                }
                else
                    MessageBox.Show(this, "Atenção! Porta fechada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception err)
            {
                MessageBox.Show("Contate o suporte! \nErro: " + err.InnerException.Message);
                PortaAberta = false;
            }

            SerialPort mySerialPort = new SerialPort("COM9", 2400, Parity.None, 8, StopBits.One);
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.WriteTimeout = 500;
            //PortChat.Porta();
            try
            {
                mySerialPort.Open();
                //String str = mySerialPort.ReadExisting();
                if (mySerialPort.BytesToRead > 0)
                {
                    string str = mySerialPort.ReadLine();
                    MessageBox.Show("Valor: " + str);
                }
                mySerialPort.Close();
            }
            catch (InvalidOperationException err)
            {
                MessageBox.Show(err.InnerException.Message);
            }
            finally
            {
                mySerialPort.Close();
            }



        }

        private void ProdutosDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelProdutosDia frm = new frmRelProdutosDia();
            frm.ShowDialog();
        }

        private void CadastroDeFolgasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (acessoFrmsRestrito())
            //{
            frmCadastroFolgasColaboradores frm = new frmCadastroFolgasColaboradores();
            frm.ShowDialog();
            //}
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Shown(object sender, EventArgs e)
        {

        }

        private void enviarMensagensBaldesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            if (DayOfWeek.Monday == agora.DayOfWeek && agora.TimeOfDay <= new TimeSpan(11, 0, 0))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT ID, NOME, ENDERECO, BALDE, TELEFONE, COLHER, DATA ");
                sql.Append("FROM BALDES ");
                sql.Append("WHERE ENTREGUE = 0 AND DATEADD(DAY, 7,DATA) < GETDATE() ");
                sql.Append("ORDER BY DATA ASC ");
                DataTable dt = auxSQL.retornaDataTable(sql.ToString());

                if (dt.Rows.Count > 0)
                {

                    string telefone = "553434121486";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        string mensagem =
                $@"Olá, {dt.Rows[i]["NOME"].ToString()}! Tudo bem?  
Notei aqui que está em aberto um  emprestado no dia {DateTime.Parse(dt.Rows[i]["DATA"].ToString()).ToString("dd/MM/yyyy")} em seu nome.  
Estamos precisando de baldes/colheres, se possível me fale uma data para buscarmos ou você trazer.  

*Se você ainda não desocupou, fique tranquilo(a), esta mensagem automática do sistema é apenas um lembrete.*  
Estamos com o estoque bem reduzido e estamos precisando.  

Agradeço sua atenção! Tenha um ótimo dia!";

                        //Codifica a mensagem para URL
                        string mensagemCodificada = WebUtility.UrlEncode(mensagem);
                        telefone = Regex.Replace(dt.Rows[i]["TELEFONE"].ToString(), @"\D", "");

                        // Monta o link do WhatsApp
                        string url = $"https://wa.me/55{telefone}?text={mensagemCodificada}";

                        // Abre no navegador padrão
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                        Thread.Sleep(5000);

                        // 3️⃣ 12 TABs (200ms entre cada)
                        for (int j = 0; j < 12; j++)
                        {
                            SendKeys.SendWait("{TAB}");
                            Thread.Sleep(200);
                        }

                        // 4️⃣ ENTER (clicar no botão)
                        SendKeys.SendWait("{ENTER}");

                        Thread.Sleep(20000);
                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(60000);


                        //WhatsAppSelenium.EnviarMensagem(telefone, mensagem);

                    }

                    MessageBox.Show("Processo de envio de mensagens finalizado!", "Processo concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Este metodo só pode ser executado na segunda-feira no período da manhã.", "Liberado apenas nas Segunda-Feiras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
