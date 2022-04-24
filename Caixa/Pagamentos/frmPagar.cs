using Componentes;
using Npgsql;
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
    public partial class frmPagar : FormJCS
    {
        private string pedidos;
        private dal.Conexao conexao = new dal.Conexao();
        private int tipoPagamento = 0; //1 = DINHEIRO; 2 = CARTAO CREDITO; 3 = CARTAO DEBITO; 4 = PIX; 5 = ANOTAR
        private bool marcarTodos = false;
        private int pedidoID;
        private SQL.SQL auxSql = new SQL.SQL();
        private double vlDividido = 0;
        private int qtLinhaSel = 0;
        private bool vlHaver = false;
        private double vlTotalPedidoAberto = 0;
        private double vlProdutosSemHaver = 0;
        private bool controleEsc = true;

        public frmPagar(int pPedidoID, string pPedidos, bool pTipo, double pVlAbertoTotalPedido)
        {
            InitializeComponent();
            this.pedidos = pPedidos;
            this.marcarTodos = pTipo;
            this.pedidoID = pPedidoID;
            this.vlTotalPedidoAberto = pVlAbertoTotalPedido;

            preencherCampos();

            cboTipoPagamento.SelectedIndex = 0;
        }

        private void preencherCampos()
        {

            DataTable dt = auxSql.buscaPedidosProdutosAberto(pedidos, marcarTodos);
            dgvPedProdAberto.DataSource = dt;

            double auxVlAberto = 0;
            for (int i =0; i < dt.Rows.Count; i++)
            {
                auxVlAberto += double.Parse(dt.Rows[i]["VL_ABERTO"].ToString());
            }

            txtValorAberto.Text = auxVlAberto.ToString("0.00");
        }

        private void escondeCampos()
        {
            if (tipoPagamento == 5)
            {
                lblAnotou.Visible = true;
                txtDescPagamento.Visible = true;
            }

            if (vlHaver)
            {
                lblTroco.Visible = false;
                txtVlRecebido.Enabled = true;
            }
            else
            {
                if (tipoPagamento == 1)
                {
                    lblTroco.Visible = true;
                    txtVlRecebido.Enabled = true;
                }
                else
                {
                    lblTroco.Visible = false;
                    txtVlRecebido.Enabled = false;
                    txtVlRecebido.Text = txtValorAberto.Text;
                }
            }
        }

        private void CboTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPagamento = cboTipoPagamento.SelectedIndex + 1;
            escondeCampos();
        }

        private bool validaCampos()
        {         
            if (tipoPagamento == 5 && string.IsNullOrEmpty(txtDescPagamento.Text))
            {
                MessageBox.Show("Informe o nome da pessoa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboTipoPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o tipo de pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tipoPagamento == 1 && string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                MessageBox.Show("Informe o valor recebido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (double.Parse(txtValorAberto.Text) > double.Parse(txtVlRecebido.Text))
            {
                MessageBox.Show("Valor Recebido menor que Valor Aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (double.Parse(txtValorAberto.Text) > vlTotalPedidoAberto)
            {
                MessageBox.Show("Existe valores em haver na tela anterior.\nPor favor, selecione todos os produtos da tela anterior!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (vlHaver && double.Parse(txtVlRecebido.Text) > vlTotalPedidoAberto)
            {
                MessageBox.Show("Não existe mais produtos em aberto para deixar o valor em haver!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (vlHaver && double.Parse(txtValorAberto.Text) == double.Parse(txtVlRecebido.Text))
            {
                MessageBox.Show("Para deixar um valor em haver, o valor recebido precisa ser maior que o valor aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                percorrerGridSalvandoVl();
                Close();
            }
        }

        private void DgvPedProdAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvPedProdAberto.Columns["colChkDividir"].Index && dgvPedProdAberto.Rows.Count > 0 && e.RowIndex != dgvPedProdAberto.Rows.Count)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("PED_PROD_ID");
                dt.Columns.Add("PRODUTO");
                dt.Columns.Add("DESC_PRODUTO");
                dt.Columns.Add("VL_ABERTO");
                dt.Columns.Add("CHKDIVIDIR");

                for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
                {
                    if (e.RowIndex == i)
                        dt.Rows.Add(dgvPedProdAberto["colPedidoProdutoID", e.RowIndex].Value, dgvPedProdAberto["colProduto", e.RowIndex].Value, dgvPedProdAberto["colDescricao", e.RowIndex].Value, dgvPedProdAberto["colValor", e.RowIndex].Value, !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString()));
                    else
                        dt.Rows.Add(dgvPedProdAberto["colPedidoProdutoID", i].Value, dgvPedProdAberto["colProduto", i].Value, dgvPedProdAberto["colDescricao", i].Value, dgvPedProdAberto["colValor", i].Value, bool.Parse(dgvPedProdAberto["colChkDividir",i].Value.ToString()));
                }

                dgvPedProdAberto.DataSource = dt;

                //dgvPedProdAberto["colChkDividir", e.RowIndex].Value = !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString());

                //if (dgvPedProdAberto["colChkDividir", e.RowIndex].Value == null || !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString()))
                //    dgvPedProdAberto["colChkDividir", e.RowIndex].Value = true;     
                //else
                //    dgvPedProdAberto["colChkDividir", e.RowIndex].Value = !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString());
                
            }
        }

        private void BtnDividirPagamento_Click(object sender, EventArgs e)
        {
            qtLinhaSel = 0;
            double vlAberto = 0;
            string pedidos = "";
            double vlTotalAberto = 0;
            for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
            {
                if ((dgvPedProdAberto["colChkDividir", i].Value != null && bool.Parse(dgvPedProdAberto["colChkDividir", i].Value.ToString())))
                {
                    qtLinhaSel++;
                    if (double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()) != 0)
                    {
                        vlAberto += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                        pedidos += dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString() + ",";
                    }
                }
                else
                {
                    vlTotalAberto += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                    vlProdutosSemHaver += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                }
            }

            if (vlAberto > 0)
            {
                pedidos = pedidos.Substring(0, pedidos.Length - 1);
                frmPagarDividido frm = new frmPagarDividido(pedidos, vlAberto);
                frm.ShowDialog();

                if (frm.vlRecebido > 0)
                {
                    dgvPedProdAberto.Enabled = false;
                    dgvPedProdAberto.Sort(dgvPedProdAberto.Columns["colChkDividir"], ListSortDirection.Descending);

                    vlDividido = frm.vlRecebido;
                    //txtValorAberto.Text = (double.Parse(txtValorAberto.Text) - vlDividido).ToString();
                    txtValorAberto.Text = (vlTotalAberto + vlDividido).ToString();

                    if (tipoPagamento != 1)
                        txtDescPagamento.Text = txtValorAberto.Text;
                }
            }


        }

        private void percorrerGridSalvandoVl()
        {
            double auxVl = 0;
            if (vlHaver)
                auxVl = double.Parse(txtVlRecebido.Text);
            else
                auxVl = double.Parse(txtValorAberto.Text);

            double vlInserir = 0;
            for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
            {
                if (auxVl > 0)
                {
                    if (i + 1 == dgvPedProdAberto.Rows.Count && vlHaver)
                    {
                        inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), auxVl);
                        auxVl = 0;
                    }

                    if (auxVl > 0)
                    {
                        if (auxVl >= double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()) || qtLinhaSel > i)
                        {
                            if (qtLinhaSel >= i + 1)
                            {
                                if (vlHaver)
                                    vlInserir = (double.Parse(txtVlRecebido.Text) - vlProdutosSemHaver) / qtLinhaSel;
                                else
                                    vlInserir = vlDividido / qtLinhaSel;
                            }
                            else
                                vlInserir = double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());

                            //vlInserir = Math.Floor(vlInserir);// Math.Round(vlInserir, );
                            auxVl -= vlInserir;

                            inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), vlInserir);

                            if (vlInserir >= double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()))
                                auxSql.updateSituacaoPedidoProduto(int.Parse(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString()), 3, "");
                        }
                        else
                        {
                            inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), auxVl);
                            auxVl = 0;
                        }
                    }
                }
            }


        }

        private void inserirPagamento (string pID, double pValor)
        {
            auxSql.insertPagamento(int.Parse(pID), pValor, tipoPagamento);
            //conexao.executarInsUpDel(auxSql.queryInsertPagamento(pID,pValor, tipoPagamento));

            if (tipoPagamento == 4)
            {
                auxSql.insertPagamentoNota(int.Parse(pID), txtDescPagamento.Text);
            }

            if (double.Parse(txtValorAberto.Text.ToString()) == 0)
            {
                auxSql.updateSituacaoPedido(pedidoID, null, 4);
            }
        }

        private void TxtVlRecebido_TextChanged(object sender, EventArgs e)
        {
            if (tipoPagamento == 1 && !string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                double aux = double.Parse(txtVlRecebido.Text) - double.Parse(txtValorAberto.Text);
                if (aux >= 0)
                    lblTroco.Text = "Troco R$ " + aux.ToString("0.00");
            }
        }

        private void ChkVlHaver_CheckedChanged(object sender, EventArgs e)
        {
            vlHaver = chkVlHaver.Checked;
            escondeCampos();


        }

        private void FrmPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmPagar_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmPagar_MouseEnter;
        }
    }
}
