using Caixa.Pedidos;
using Componentes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    public partial class frmNovoPedido : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private int tipoOperacao;//1 = INSERT; 2 = UPDATE; 3 = UPDATE PRODUTO GRIDVIEW
        private int pedidoProdutoID;
        private bool controleEsc = true;
        private int qtDescricao = 0, qtDescricaoMax = 0;
        private DataTable dtFilhos;

        public frmNovoPedido(int pTipoOperacao, int pPedido)
        {
            InitializeComponent();

            preencherCombo(auxSQL.buscaProdutoPai(), cboProdutoPai, 0);
            cboProdutoPai.SelectedIndex = 0;

            preencherCombo(auxSQL.buscaTipoPedido(), cboTipo, 0);
            cboTipo.SelectedIndex = 0;

            //RECEBENDO PARAMETROS
            this.tipoOperacao = pTipoOperacao;
            if (pPedido > 0)
            {
                modoUpdate(pPedido);
            }
        }

        private void modoUpdate (int pPedido)
        {
            txtPedidoID.Text = pPedido.ToString();
            preencherGrid(pPedido);
            preencherCampos();
            btnCancelarPedido.Visible = true;
            txtDescPedido.Enabled = false;
            cboTipo.Enabled = false;
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string auxDesc = "";
                List<string> listaDesc = new List<string>();
                List<string> listaOrdernada = new List<string>();
                string obsProduto = "";

                StringBuilder sql = new StringBuilder();

                auxDesc = txtDescricaoProduto.Text;
                if (cboDesc1.SelectedIndex > -1)
                    listaDesc.Add(cboDesc1.SelectedItem.ToString());
                    //auxDesc += cboDesc1.SelectedItem.ToString();
                if (cboDesc2.SelectedIndex > -1)
                    listaDesc.Add(cboDesc2.SelectedItem.ToString());
                //auxDesc += ", " + cboDesc2.SelectedItem.ToString();
                if (cboDesc3.SelectedIndex > -1)
                    listaDesc.Add(cboDesc3.SelectedItem.ToString());
                //auxDesc += ", " + cboDesc3.SelectedItem.ToString();
                if (cboDesc4.SelectedIndex > -1)
                    listaDesc.Add(cboDesc4.SelectedItem.ToString());
                //auxDesc += ", " + cboDesc4.SelectedItem.ToString();
                if (cboDesc5.SelectedIndex > -1)
                    listaDesc.Add(cboDesc5.SelectedItem.ToString());
                //auxDesc += ", " + cboDesc5.SelectedItem.ToString();
                if (cboDesc6.SelectedIndex > -1)
                    listaDesc.Add(cboDesc6.SelectedItem.ToString());
                //auxDesc += ", " + cboDesc6.SelectedItem.ToString();

                listaOrdernada = listaDesc.OrderBy(x => x).ToList();
                for (int i = 0; i < listaOrdernada.Count; i++)
                {
                    if (i == 0)
                    {
                        auxDesc += listaOrdernada[i];
                    }
                    else
                    {
                        auxDesc += ", " + listaOrdernada[i];
                    }
                }


                if (!string.IsNullOrEmpty(txtCobertura.Text))
                    auxDesc += " COB.:(" + txtCobertura.Text + ")";
                if (!string.IsNullOrEmpty(txtObservacao.Text))
                    obsProduto =  txtObservacao.Text ;

                if (tipoOperacao == 1 || tipoOperacao == 2)
                {

                    if (tipoOperacao == 1)
                    {
                        DataTable dt = auxSQL.buscaDescPedidoAberto(txtDescPedido.Text);
                        if (dt.Rows.Count > 0)
                        {
                            DialogResult result = MessageBox.Show("Este pedido ainda está aberto.\n Deseja adicionar mais produtos?", "Pedido em Aberto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                                modoUpdate(int.Parse(dt.Rows[0]["ID"].ToString()));
                            else
                                return;
                        }
                        else
                        {
                            string endereco = "", obsPedido = "";
                            if (!txtObservacaoPedido.Text.Equals("TROCO OU CARTÃO"))
                                obsPedido = txtObservacaoPedido.Text;
                            if (!txtEndereco.Text.Equals("ENDEREÇO"))
                                endereco = txtEndereco.Text;

                            auxSQL.insertPedido(txtDescPedido.Text.ToString(), cboTipo.SelectedItem.ToString(), 1, endereco, obsPedido, 1);

                            txtPedidoID.Text = auxSQL.buscaUltimoPedido(txtDescPedido.Text.ToString()).Rows[0][0].ToString();
                        }
                    }

                    //auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), cboProdutoFilho.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), auxDesc, cboTipo.SelectedItem.ToString(), 1);
                    //auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), cboProdutoFilho.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), auxDesc, obsProduto, 1);
                    double qt = double.Parse(txtQuantidade.Text);
                    if (cboProdutoFilho.SelectedItem.Equals("SORVETE KILO CASCAO/CASQUINHA"))
                        qt = qt - 0.088;

                    List<string> potes = new List<string>();
                    potes.Add("POTE 04L");
                    potes.Add("POTE 05L");
                    potes.Add("POTE 10L");

                    if (potes.Contains(cboProdutoFilho.SelectedItem.ToString()))
                    {
                        if (string.IsNullOrEmpty(auxDesc))
                        {
                            StringBuilder sqlPote = new StringBuilder();
                            sqlPote.Append("SELECT EP.ID, EP.PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE  ");
                            sqlPote.Append("FROM ESTOQUE_POTE EP ");
                            sqlPote.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
                            sqlPote.Append("WHERE EP.QT_EST > 0 AND     P.DESCRICAO = '" + cboProdutoFilho.SelectedItem.ToString() + "' ");
                            sqlPote.Append("ORDER BY DESCRICAO");

                            while (true)
                            {
                                frmBusca frm = new frmBusca(sqlPote, "Estoque dos Sabores de " + cboProdutoFilho.SelectedItem.ToString());
                                frm.ShowDialog();
                                if (frm.retorno != null)
                                {
                                    auxDesc = frm.retorno["DESCRICAO"].ToString();
                                    //auxSQL.updateAddEstoquePote(int.Parse(frm.retorno["ID"].ToString()), int.Parse(dtGrid.Rows[listPosicaoGrid[i]]["QT"].ToString()) * -1);
                                    break;
                                }
                                else
                                {

                                    MessageBox.Show("É obrigatório escolher o pote de sorvete!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                        
                    

                    auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), cboProdutoFilho.SelectedItem.ToString(), qt, auxDesc, obsProduto, 1);

                    cboTipo.Enabled = false;
                }
                else
                {
                    auxSQL.updatePedidoProduto(pedidoProdutoID, cboProdutoFilho.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), auxDesc, cboTipo.SelectedItem.ToString());
                    btnAddProduto.Text = "Novo Produto";
                }

                btnCancelarPedido.Visible = true;
                tipoOperacao = 2;

                preencherGrid(int.Parse(txtPedidoID.Text));
            }
        }

        private void BtnCancelarPedido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar esse pedido?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    frmInputBoxJCS frm = new frmInputBoxJCS("Informe o motivo do cancelamento.", 3);
                    frm.ShowDialog();

                    if (!string.IsNullOrEmpty(frm.retorno))
                    {
                        cancelarPedido(frm.retorno);

                        Close();
                    }
                }
            }
        }
        private void cancelarPedido(string pDescricao)
        {
            auxSQL.updatePedido(int.Parse(txtPedidoID.Text), 0, pDescricao, "", "");
        }

        private void BtnEnviarPedido_Click(object sender, EventArgs e)
        {
                if (validarCampos() && dgvProdutos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja enviar o pedido pra cozinha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        if (cboTipo.SelectedIndex == 2)
                        {
                            auxSQL.updatePedido(int.Parse(txtPedidoID.Text), 1, txtDescPedido.Text, txtEndereco.Text, txtObservacaoPedido.Text);
                            if (auxSQL.retornaDataTable("SELECT * FROM PEDIDO_PRODUTO WHERE PRODUTO = 91 AND PEDIDO = " + int.Parse(txtPedidoID.Text)).Rows.Count == 0)
                            {
                                auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), "TAXA DE ENTREGA", 1, "", "", 8);
                            }
                        }

                        enviarPedido(8);
                        Close();
                    }
                }
            }
        }

        private void CboProdutoPai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtFilhos = auxSQL.buscaProdutoFilho(cboProdutoPai.SelectedItem.ToString());
            preencherCombo(dtFilhos, cboProdutoFilho, 0);
            cboProdutoFilho.SelectedIndex = 0;
            
            DataTable dt = auxSQL.buscaSabor(cboProdutoPai.SelectedItem.ToString());
            preencherCombo(dt, cboDesc1, 1);
            preencherCombo(dt, cboDesc2, 1);
            preencherCombo(dt, cboDesc3, 1);
            preencherCombo(dt, cboDesc4, 1);
            preencherCombo(dt, cboDesc5, 1);
            preencherCombo(dt, cboDesc6, 1);
        }

        private void TxtDescPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM PEDIDO_PRODUTO ");
                frmBusca frm = new frmBusca(sql, "Busca Pedidos");
                frm.ShowDialog();
            }
        }

        private void enviarPedido(int pSituacao)
        {
            int auxID = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count-1; i++)
            {
                auxID = int.Parse(dgvProdutos["colPedidoProdutoID", i].Value.ToString());
                auxSQL.updateSituacaoPedidoProduto(auxID, pSituacao, "");                
            }
        }

        private void preencherCombo(DataTable pDTable, ComboBox pCombo, int pOcultar)
        {
            
            if (pOcultar == 1 || pDTable.Rows.Count == 0)
            {
                pCombo.Visible = false;
            }
            {
                pCombo.Items.Clear();
                pCombo.Visible = true;
                for (int i = 0; i < pDTable.Rows.Count; i++)
                {
                    pCombo.Items.Add(pDTable.Rows[i]["descricao"]);
                }
            }
        }

        private Boolean validarCampos()
        {
            if (string.IsNullOrEmpty(txtDescPedido.Text.ToString()))
            {
                MessageBox.Show("Informe a Descrição do Pedido.");
                txtDescPedido.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtQuantidade.Text.ToString()))
            {
                MessageBox.Show("Informe a Quantidade de Produto.");
                txtQuantidade.Focus();
                return false;
            }

            if (cboTipo.SelectedIndex == 2 && (txtEndereco.Text.Equals("ENDEREÇO")  || string.IsNullOrEmpty(txtEndereco.Text)))
            {
                MessageBox.Show("Informe o endereço da entrega.");
                txtEndereco.Focus();
                return false;
            }

            return true;
        }

        private Boolean validarPedido ()
        {

            return true;
        }

        private void preencherGrid(int pID)
        {
            DataTable dt = auxSQL.buscaPedidoProdutoAberto(pID);
            dgvProdutos.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                btnEnviarPedido.Visible = true;
                btnEnviarPedidoSemImprimir.Visible = true;
            }
            else
            {
                btnEnviarPedido.Visible = false;
                btnEnviarPedidoSemImprimir.Visible = false;
            }
        }

        private void preencherCampos()
        {
            DataTable dt = auxSQL.buscaInformacoesPedido(int.Parse(txtPedidoID.Text.ToString()));

            if (dt.Rows.Count > 0)
            {
                txtDescPedido.Text = dt.Rows[0]["DESCRICAO"].ToString();
                cboTipo.SelectedItem = dt.Rows[0]["TIPO"].ToString();
                tipoOperacao = 2;
            }
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProdutos.Columns["colEditar"].Index && dgvProdutos.Rows.Count > 0 && e.RowIndex+1 != dgvProdutos.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Deseja editar esse produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pedidoProdutoID = int.Parse(dgvProdutos["colPedidoProdutoID", e.RowIndex].Value.ToString());

                    preencheCamposUpdateProduto();
                    tipoOperacao = 3;
                    btnAddProduto.Text = "Editar Produto";
                }

            }

            if (e.ColumnIndex == dgvProdutos.Columns["colExcluir"].Index && dgvProdutos.Rows.Count > 0 && e.RowIndex + 1 != dgvProdutos.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Deseja cancelar esse produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        pedidoProdutoID = int.Parse(dgvProdutos["colPedidoProdutoID", e.RowIndex].Value.ToString());
                        cancelarProduto();

                        preencherGrid(int.Parse(txtPedidoID.Text));
                    }
                }
            }

            if (e.ColumnIndex == dgvProdutos.Columns["colAddAdicionais"].Index && dgvProdutos.Rows.Count > 0 && e.RowIndex + 1 != dgvProdutos.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Deseja adicionar adicionais a este produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        pedidoProdutoID = int.Parse(dgvProdutos["colPedidoProdutoID", e.RowIndex].Value.ToString());
                        //frmNovoPedidoAdicionais frm = new frmNovoPedidoAdicionais(pedidoProdutoID, double.Parse(dgvProdutos["colValor", e.RowIndex].Value.ToString()), int.Parse(dgvProdutos["colQuantidade", e.RowIndex].Value.ToString()));
                        frmNovoPedidoAdicionais frm = new frmNovoPedidoAdicionais(pedidoProdutoID, double.Parse(dgvProdutos["colValor", e.RowIndex].Value.ToString()), double.Parse(dgvProdutos["colQuantidade", e.RowIndex].Value.ToString()));
                        frm.ShowDialog();

                        preencherGrid(int.Parse(txtPedidoID.Text));
                    }
                }
            }
        }

        private void cancelarProduto ()
        {
            auxSQL.updateSituacaoPedidoProduto(pedidoProdutoID, 0, "CANCELADO NO DESKTOP ANTES DE ENVIAR");
        }

        private void preencheCamposUpdateProduto()
        {
            DataTable dt = auxSQL.buscaInformacoesPedido(pedidoProdutoID);
            txtDescricaoProduto.Text = dt.Rows[0]["DESC_PRODUTO"].ToString();
            txtQuantidade.Text = dt.Rows[0]["QT_PRODUTO"].ToString();
            cboProdutoPai.SelectedItem = dt.Rows[0]["PRODUTO_PAI"].ToString();
            cboProdutoFilho.SelectedItem = dt.Rows[0]["PRODUTO_FILHO"].ToString();
            cboTipo.SelectedItem = dt.Rows[0]["TIPO"].ToString();
        }

        private void CboProdutoFilho_SelectedIndexChanged(object sender, EventArgs e)
        {
            alterarIndexFilho();
        }
        private void alterarIndexFilho ()
        {
            qtDescricaoMax = int.Parse(dtFilhos.Rows[cboProdutoFilho.SelectedIndex]["QT_DESCRICAO"].ToString());
            qtDescricao = 0;


            if (qtDescricaoMax == -1)
                cboDesc1.Enabled = false;
            else
                cboDesc1.Enabled = true;


            cboDesc1.SelectedIndex = -1;
            cboDesc2.SelectedIndex = -1;
            cboDesc3.SelectedIndex = -1;
            cboDesc4.SelectedIndex = -1;
            cboDesc5.SelectedIndex = -1;
            cboDesc6.SelectedIndex = -1;
            cboDesc2.Enabled = false;
            cboDesc3.Enabled = false;
            cboDesc4.Enabled = false;
            cboDesc5.Enabled = false;
            cboDesc6.Enabled = false;

            txtDescricaoProduto.Text = "";
            txtQuantidade.Text = "1";
            txtCobertura.Text = "";
            txtObservacao.Text = "";

            if (cboProdutoFilho.SelectedItem.Equals("SORVETE KILO") || cboProdutoFilho.SelectedItem.Equals("SORVETE KILO CASCAO/CASQUINHA"))
            {
                txtQuantidade.TipoCampo = "DOUBLE";
            }
            else
            {
                txtQuantidade.TipoCampo = "INTEIRO";
            }
        }

        private void FrmNovoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmNovoPedido_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmNovoPedido_MouseEnter;
        }

        private void CboDesc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 1;
            if (qtDescricao == qtDescricaoMax)
            {
                cboDesc2.Enabled = false;
                cboDesc2.SelectedIndex = -1;
            }
            else
                cboDesc2.Enabled = true;
        }

        private void CboDesc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesc1.SelectedIndex > -1)
                qtDescricao = 2;

            if (qtDescricao == qtDescricaoMax)
            {
                cboDesc3.SelectedIndex = -1;
                cboDesc3.Enabled = false;
            }
            else
                cboDesc3.Enabled = true;
        }

        private void CboDesc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesc2.SelectedIndex > -1)
                qtDescricao = 3;

            if (qtDescricao == qtDescricaoMax)
            {
                cboDesc4.SelectedIndex = -1;
                cboDesc4.Enabled = false;
            }
            else
                cboDesc4.Enabled = true;
        }


        private void CboDesc4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesc3.SelectedIndex > -1)
                qtDescricao = 4;

            if (qtDescricao == qtDescricaoMax)
            {
                cboDesc5.SelectedIndex = -1;
                cboDesc5.Enabled = false;
            }
            else
                cboDesc5.Enabled = true;
        }

        private void CboDesc6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboDesc6.SelectedIndex = -1;
                cboDesc6.Enabled = false;
                cboDesc5.Focus();
            }
        }

        private void CboDesc5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboDesc5.SelectedIndex = -1;
                cboDesc5.Enabled = false;
                cboDesc4.Focus();
            }
        }

        private void CboDesc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboDesc3.SelectedIndex = -1;
                cboDesc3.Enabled = false;
                cboDesc2.Focus();
            }
        }

        private void CboDesc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboDesc2.SelectedIndex = -1;
                cboDesc2.Enabled = false;
                cboDesc1.Focus();
            }
        }

        private void TxtEndereco_Enter(object sender, EventArgs e)
        {
            txtEndereco.Text = "";
        }

        private void CboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 2)
            {
                txtEndereco.Visible = true;
                txtObservacaoPedido.Visible = true;
            }
            else
            {
                txtEndereco.Visible = false;
                txtObservacaoPedido.Visible = false;
            }
        }

        private void TxtObservacaoPedido_Enter(object sender, EventArgs e)
        {
            txtObservacaoPedido.Text = "";
        }

        private void BtnEnviarPedidoSemImprimir_Click(object sender, EventArgs e)
        {
            if (validarCampos() && dgvProdutos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja enviar o pedido pra cozinha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        if (cboTipo.SelectedIndex == 2)
                        {
                            auxSQL.updatePedido(int.Parse(txtPedidoID.Text), 1, txtDescPedido.Text, txtEndereco.Text, txtObservacaoPedido.Text);
                            if (auxSQL.retornaDataTable("SELECT * FROM PEDIDO_PRODUTO WHERE PRODUTO = 91 AND PEDIDO = " + int.Parse(txtPedidoID.Text)).Rows.Count == 0)
                            {
                                auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), "TAXA DE ENTREGA", 1, "","", 2);
                            }
                        }

                        enviarPedido(2);
                        Close();
                    }
                }
            }
        }

        private void CboDesc5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDesc4.SelectedIndex > -1)
                qtDescricao = 5;

            if (qtDescricao == qtDescricaoMax)
            {
                cboDesc6.SelectedIndex = -1;
                cboDesc6.Enabled = false;
            }
            else
                cboDesc6.Enabled = true;
        }

    }
}
