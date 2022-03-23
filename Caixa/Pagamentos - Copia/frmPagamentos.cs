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
    public partial class frmPagamentos : FormJCS
    {
        private int pedidoID;
        private string descPedido;
        private int situacao;
        private dal.Conexao conexao = new dal.Conexao();
        private SQL.SQL sqlAux = new SQL.SQL();
        private bool controleEsc = true;

        public frmPagamentos(int pPedido, string pDescricao, int pSituacao)
        {
            InitializeComponent();

            this.pedidoID = pPedido;
            this.descPedido = pDescricao;
            this.situacao = pSituacao;

            txtPedidoID.Text = pedidoID.ToString();
            txtDescPedido.Text = descPedido;

            preencherCampos();
            habilitaCampos();
            //DataTable dt = new DataTable();
            //dt = sqlAux.buscaTipoPedido(2);
            //DataTable dt = conexao.dtTeste(0);
        }

        private void habilitaCampos()
        {
            bool auxHabilita = false;
            if (situacao == 1)
                auxHabilita = true;

            btnPagarSelecionados.Enabled = auxHabilita;
            btnPagarTudo.Enabled = auxHabilita;
            dgvProdutosAbertos.Enabled = auxHabilita;
        }

        private void preencherCampos()
        {
            DataTable dt = sqlAux.buscaValoresPedido(pedidoID);
            dgvProdutosAbertos.DataSource = dt;

            double auxVlPago = 0, auxVlAberto = 0;

            if (dgvProdutosAbertos.Rows.Count > 0)
            {
                for (int i = 0; i < dgvProdutosAbertos.Rows.Count; i++)
                {
                    auxVlAberto += double.Parse(dgvProdutosAbertos["colVlAberto", i].Value.ToString());
                    auxVlPago += double.Parse(dgvProdutosAbertos["colValorPago", i].Value.ToString());
                }
            }

            txtVlAberto.Text = auxVlAberto.ToString("0.00");
            txtVlPago.Text = auxVlPago.ToString("0.00");
            txtVlTotal.Text = (auxVlAberto + auxVlPago).ToString("0.00");

            lblSituacao.Text = "PEDIDO: " + sqlAux.buscaInformacoesPedido(pedidoID).Rows[0]["DESC_SITUACAO"].ToString();
        }

        private void DgvProdutosAbertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvProdutosAbertos.Columns["colChkPagar"].Index && dgvProdutosAbertos.Rows.Count > 0 && e.RowIndex != dgvProdutosAbertos.Rows.Count)
            {
                if (double.Parse(txtVlAberto.Text) != 0)
                {
                    double aux = double.Parse(dgvProdutosAbertos["colVlAberto", e.RowIndex].Value.ToString());
                    if (aux != 0)
                    {
                        if (dgvProdutosAbertos["colChkPagar", e.RowIndex].Value == null)
                            dgvProdutosAbertos["colChkPagar", e.RowIndex].Value = true;
                        else
                            dgvProdutosAbertos["colChkPagar", e.RowIndex].Value = !bool.Parse(dgvProdutosAbertos["colChkPagar", e.RowIndex].Value.ToString());
                    }
                }
            }
        }
        private void validaPedidos(bool pTipo)
        {
            if (double.Parse(txtVlAberto.Text) == 0)
            {
                MessageBox.Show("Este pedido já está pago!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                string pedidos = retornaPedidos(pTipo);

                if (string.IsNullOrEmpty(pedidos) && !pTipo)
                {
                    MessageBox.Show("Selecione pelo menos 1 produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                pedidos = pedidos.Substring(0, pedidos.Length - 1);

                frmPagar frm = new frmPagar(pedidoID, pedidos, pTipo, double.Parse(txtVlAberto.Text));
                frm.ShowDialog();

                preencherCampos();

            if (double.Parse(txtVlAberto.Text) == 0)
            {
                sqlAux.updateSituacaoPedido(pedidoID, "", 4);
                Close();
            }
        }


        private void BtnPagarSelecionados_Click(object sender, EventArgs e)
        {
            validaPedidos(false);
        }

        private void BtnPagarTudo_Click(object sender, EventArgs e)
        {
            validaPedidos(true);
        }

        private void DgvProdutosAbertos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //VALOR EM ABERTO
            if (dgvProdutosAbertos.Columns[e.ColumnIndex].Name == "colVlAberto")
            {
                DataGridViewRow row = dgvProdutosAbertos.Rows[e.RowIndex];
                if (double.Parse(e.Value.ToString()) == 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0F8E0");
                }
                else if (double.Parse(e.Value.ToString()) > 0 && double.Parse(dgvProdutosAbertos["colValorPago", e.RowIndex].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FBEFEF");
                }
                else if (double.Parse(e.Value.ToString()) < 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0F2F7");
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private string retornaPedidos (bool pTipo)//0 = SELECIONADOS; 1 = TODOS
        {
            string pedidos = "";

            for (int i = 0; i < dgvProdutosAbertos.Rows.Count; i++)
            {
                if ((dgvProdutosAbertos["colChkPagar", i].Value != null && bool.Parse(dgvProdutosAbertos["colChkPagar", i].Value.ToString())) || pTipo ) //|| double.Parse(dgvProdutosAbertos["colVlAberto", i].Value.ToString()) <0)
                {
                    if (double.Parse(dgvProdutosAbertos["colVlAberto", i].Value.ToString()) != 0)
                        pedidos += dgvProdutosAbertos["colPedidoProdutoID", i].Value.ToString() + ",";
                }
            }

            return pedidos;
        }

        private void FrmPagamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmPagamentos_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmPagamentos_MouseEnter;
        }
    }
}
