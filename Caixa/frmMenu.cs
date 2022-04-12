using System;
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
using Caixa.Caixa;
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

            if (verificarImpressora())
            {
                Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));
                trd.IsBackground = true;
                trd.Start();
            }


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
                StringBuilder sImpressao = new StringBuilder();
                int indexAux;
                string descricao, observacao, cobertura;
                string auxDescPedido = "";

                if (dt.Rows.Count > 0)
                {
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

                            if (!auxDescPedido.Equals(dt.Rows[i]["DESC_PEDIDO"].ToString()))
                            {
                                auxDescPedido = dt.Rows[i]["DESC_PEDIDO"].ToString();
                                sImpressao.Append("Desc. Ped.: " + auxDescPedido + "\r\n\r\n");
                            }

                            cobertura = "";
                            observacao = "";
                            descricao = dt.Rows[i]["DESC_PRODUTO"].ToString();
                            sImpressao.Append((i + 1).ToString("00") + "  -      QT. " + dt.Rows[i]["QT_PRODUTO"].ToString() + "  -  " + dt.Rows[i]["PRODUTO"].ToString() + "\r\n");

                            //sImpressao.Append("   " + dt.Rows[");");
                            if (!string.IsNullOrEmpty(descricao))
                            {
                                if (descricao.Contains("OBS.:"))
                                {
                                    indexAux = descricao.IndexOf("OBS.:");
                                    observacao = descricao.Substring(indexAux);
                                    descricao = descricao.Substring(0, descricao.Length - observacao.Length);
                                }

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
                                if (!string.IsNullOrEmpty(observacao))
                                    sImpressao.Append("           " + observacao + "\r\n");
                            }

                            sImpressao.Append("Valor: " + dt.Rows[i]["VL_TOTAL"].ToString() + "\r\n");
                            sImpressao.Append("------------------------------------------------" + "\r\n");



                            SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                            sqlc.CommandType = CommandType.Text;
                            sqlc.Parameters.AddWithValue("@pedProdID", int.Parse(dt.Rows[i]["PED_PROD_ID"].ToString()));
                            sqlc.Parameters.AddWithValue("@situacao", 2);
                            auxSQL.executaQueryTransaction(conn, sqlc); //DESCOMENTAR DEPOIS
                        }
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

                Thread.Sleep(5000);
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
    }
}
