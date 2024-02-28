﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa.Cadastro;
using Caixa.Caixa;
using Caixa.Estoque;
using Caixa.Pagamentos;
using Caixa.Reports;
using Componentes;
using Npgsql;

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

        public frmMenu()
        {
            InitializeComponent();

            //if (verificarImpressora())
            //{
                Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));
                trd.IsBackground = true;
                trd.Start();
            //}


            frmPedidos frm = new frmPedidos();
            frm.MdiParent = this;
            frm.Show();
        }

        private Boolean verificarImpressora ()
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
                DataTable dt = auxSQL.retornaTeste();
                DataTable dtAdds;
                StringBuilder sImpressao = new StringBuilder();
                int indexAux;
                double valor = 0, vlTotal = 0;
                string descricao, observacao, observacaoPed= "", endereco = "", cobertura;
                string auxDescPedido = "";
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
                                    sImpressao.Append("           " + descricao + "\r\n");

                                if (!string.IsNullOrEmpty(cobertura))
                                    sImpressao.Append("           " + cobertura + "\r\n");
                                }

                                if (!string.IsNullOrEmpty(observacao))
                                    sImpressao.Append("           OBS.: " + observacao + "\r\n");


                            dtAdds = auxSQL.retornaPedidosAdds(int.Parse(dt.Rows[i]["PED_PROD_ID"].ToString()));
                            valor = double.Parse(dt.Rows[i]["VL_TOTAL"].ToString());
                            for (int j = 0; j < dtAdds.Rows.Count; j++)
                            {
                                valor += double.Parse(dtAdds.Rows[j]["VALOR"].ToString());
                                if (!string.IsNullOrEmpty(dtAdds.Rows[j]["DESCRICAO"].ToString()))
                                        sImpressao.Append("Adicional: " + dtAdds.Rows[j]["QT_PRODUTO"].ToString() + "x "  + dtAdds.Rows[j]["PRODUTO"].ToString() + " - " + dtAdds.Rows[j]["DESCRICAO"].ToString());
                                    else
                                        sImpressao.Append("Adicional: " + dtAdds.Rows[j]["QT_PRODUTO"].ToString() + "x " + dtAdds.Rows[j]["PRODUTO"].ToString());
                                sImpressao.Append("\r\n");
                            }
                            vlTotal+= valor;
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
                                sImpressao.Append("ENDEREÇO: " + endereco + "\r\n");
                                if (!string.IsNullOrEmpty(observacaoPed))
                                    sImpressao.Append("OBSERVAÇÃO: " + observacaoPed + "\r\n");


}
                        if (tipo == 2)
                                {
                                sImpressao.Append("*********************LEVAR*********************" + "\r\n");


}
                        sImpressao.Append("VALOR TOTAL:" + vlTotal + "\r\n");

                        sImpressao.Append("PAGAMENTO SOMENTE NO CAIXA!!!" + "\r\n");
                        sImpressao.Append("\r\n\r\n\r\n");
                        //iRetorno = MP2032.FormataTX(sImpressao + "\r\n\r\n", 1, 1, 0, 0, 0);

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
                    catch(Exception e)
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
                Thread.Sleep(1000);
                }
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
                    this.Close();
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
                frmLinkEstoqueProduto frm = new frmLinkEstoqueProduto();
                frm.ShowDialog();
            }
        }

        private void LinkEstoqueXProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (acessoFrmsRestrito())
            //{
                frmLinkEstoqueProduto frm = new frmLinkEstoqueProduto();
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
            sql.Append("SELECT F.NOME FORNECEDOR, P.COD_PROD CODIGO, P.DESC_PROD PRODUTO, QT_COM QT_COMPRADA, P.UN_COMERCIAL, VL_UNIT, N.DT_ENTREGA ");
            sql.Append("FROM NF N ");
            sql.Append("JOIN NF_PROD P ON(P.NF = N.ID) ");
            sql.Append("JOIN fornecedor F ON(N.FORNECEDOR = F.ID) ");
            //sql.Append("ORDER BY P.DESC_PROD, DT_ENTREGA DESC ");
            frmBusca frm = new frmBusca(sql, "Entradas de Notas Fiscais");
            frm.ShowDialog();
        }

        private void ProdutosParaComprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            sql.Append("JOIN(SELECT SE.ID_EST_POTE, COUNT(ID_SABOR) QT_SABOR FROM SABOR_ESTOQUE SE GROUP BY SE.ID_EST_POTE) AUX ON(AUX.ID_EST_POTE = EP.ID) ");
            sql.Append("WHERE P.TIPO = 4 AND P.DESCRICAO = 'POTE 10L' AND EP.QT_EST = 0 AND AUX.QT_SABOR = 1 ");
            sql.Append("ORDER BY DESCRICAO ");
            frmBusca frm = new frmBusca(sql, "Potes 10L Em Falta");
            frm.ShowDialog();
        }

        private void SubtrairEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubEstoque frm = new frmSubEstoque();
            frm.ShowDialog();
        }
    }
}
