using Componentes;
using System;
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
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string auxDesc = "";
                StringBuilder sql = new StringBuilder();

                auxDesc = txtDescricaoProduto.Text;
                if (cboDesc1.SelectedIndex > -1)
                    auxDesc += cboDesc1.SelectedItem.ToString();
                if (cboDesc2.SelectedIndex > -1)
                    auxDesc += ", " + cboDesc2.SelectedItem.ToString();
                if (cboDesc3.SelectedIndex > -1)
                    auxDesc += ", " + cboDesc3.SelectedItem.ToString();
                if (cboDesc4.SelectedIndex > -1)
                    auxDesc += ", " + cboDesc4.SelectedItem.ToString();
                if (cboDesc5.SelectedIndex > -1)
                    auxDesc += ", " + cboDesc5.SelectedItem.ToString();
                if (cboDesc6.SelectedIndex > -1)
                    auxDesc += ", " + cboDesc6.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(txtCobertura.Text))
                    auxDesc += " COB.:(" + txtCobertura.Text + ")";
                if (!string.IsNullOrEmpty(txtObservacao.Text))
                    auxDesc += " OBS.:" + txtObservacao.Text + "";

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
                            auxSQL.insertPedido(txtDescPedido.Text.ToString(), cboTipo.SelectedItem.ToString(), 1);

                            txtPedidoID.Text = auxSQL.buscaUltimoPedido(txtDescPedido.Text.ToString()).Rows[0][0].ToString();
                        }
                    }

                    //auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), cboProdutoFilho.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), auxDesc, cboTipo.SelectedItem.ToString(), 1);
                    auxSQL.insertPedidoProduto(int.Parse(txtPedidoID.Text), cboProdutoFilho.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), auxDesc, 1);

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
            auxSQL.updatePedido(int.Parse(txtPedidoID.Text), 0, pDescricao);
        }

        private void BtnEnviarPedido_Click(object sender, EventArgs e)
        {
                if (validarCampos() && dgvProdutos.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja enviar o pedido pra cozinha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        enviarPedido();
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

        private void enviarPedido()
        {
            int auxID = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count-1; i++)
            {
                auxID = int.Parse(dgvProdutos["colPedidoProdutoID", i].Value.ToString());
                auxSQL.updateSituacaoPedidoProduto(auxID, 8, "");
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
                btnEnviarPedido.Visible = true;
            else
                btnEnviarPedido.Visible = false;
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
