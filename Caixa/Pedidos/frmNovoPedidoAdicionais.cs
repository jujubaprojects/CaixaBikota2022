using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componentes;

namespace Caixa.Pedidos
{
    public partial class frmNovoPedidoAdicionais : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        //private int qtProduto = 0;
        private double qtProduto = 0;
        private int pedidoProdID = 0;
        private double valorProdSemAdd = 0, valorAdd = 0;
       
        public frmNovoPedidoAdicionais(int pPedidoProduto, double pValor, double pQuantidadeProd /*int pQuantidadeProd*/)
        {
            InitializeComponent();

            preencherCombo(auxSQL.buscaProdutoFilho("ADICIONAIS"),cboAdicional,0);

            pedidoProdID = pPedidoProduto;
            valorProdSemAdd = pValor;
            qtProduto = pQuantidadeProd;


            DataTable dt = auxSQL.buscaPedidoProdutoCampos(pedidoProdID);
            txtProduto.Text = dt.Rows[0]["PRODUTO"].ToString();

            preencherGrid(0);
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

        private void BtnAddAdicional_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                auxSQL.insertPedidoProdutoAdicional(pedidoProdID, cboAdicional.SelectedItem.ToString(), int.Parse(txtQuantidade.Text), txtObservacao.Text);
                preencherGrid();
            }
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text) || int.Parse(txtQuantidade.Text) < 1)
            {
                MessageBox.Show("Informe uma quantidade maior que 0.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAdicionais.Columns["colExcluir"].Index && dgvAdicionais.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir este adicional?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.excluirPedidoProdutoAdicional(int.Parse(dgvAdicionais["colPedProdAddID", e.RowIndex].Value.ToString()));
                        preencherGrid();
                    }
                }
            }
        }

        private void preencherGrid (int pEntrada = 1)
        {
            valorAdd = 0;
            DataTable dt = auxSQL.buscaPedidoProdutoAdd(pedidoProdID);
            int qtAdd = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                valorAdd += double.Parse(dt.Rows[i]["VL_TOTAL"].ToString()) * int.Parse(dt.Rows[i]["QT_PRODUTO"].ToString());
                
            }

            if (pEntrada == 1)
                if (qtProduto > 1)
                    lblValor.Text = "Valor Total: R$ " + ((qtProduto * valorAdd) + valorProdSemAdd).ToString("0.00");
                else
                    lblValor.Text = "Valor Total: R$ " + ((qtProduto * valorAdd) + valorProdSemAdd).ToString("0.00");
            else
            {
                valorProdSemAdd = valorProdSemAdd - valorAdd;
                lblValor.Text = "Valor Total: R$ " + (valorAdd + valorProdSemAdd).ToString("0.00");
            }
            dgvAdicionais.DataSource = dt;
        }
    }
}
