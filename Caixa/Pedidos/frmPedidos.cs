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
    public partial class frmPedidos : FormJCS
    {
        private int tipo = 1;
        private int situacao = 1;
        private SQL.SQL sqlAux = new SQL.SQL();
        private bool controleEsc = true;

        public frmPedidos()
        {
            InitializeComponent();

            cboSituacao.SelectedIndex = 0;
            this.WindowState = FormWindowState.Maximized;
        }

        private void CboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSituacao.SelectedIndex)
            {
                //ABERTO
                case 0:
                    dgvPedidos.Columns["colEditar"].Visible = true;
                    dgvPedidos.Columns["colCancelar"].Visible = true;
                    situacao = 1;
                    break;

                //FINALIZADO
                case 1:
                    dgvPedidos.Columns["colEditar"].Visible = false;
                    dgvPedidos.Columns["colCancelar"].Visible = false;
                    situacao = 4;
                    break;

                //CANCELADO
                case 2:
                    dgvPedidos.Columns["colEditar"].Visible = false;
                    dgvPedidos.Columns["colCancelar"].Visible = false;
                    situacao = 0;
                    break;
            }

            preencherPedidos();            
        }

        private void preencherPedidos()
        {
            //DataTable dt = conexao.executarSelect(sqlAux.queryBuscaPedidos(situacao,tipo, dtpDataPedido.Value.ToShortDateString().ToString()));
            //dgvPedidos.DataSource = dt;
            dgvPedidos.DataSource = sqlAux.buscaPedidos(situacao, tipo, dtpDataPedido.Value.ToShortDateString().ToString());
        }

        private void RbtMesas_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            preencherPedidos();
        }
        private void RbtLevar_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            preencherPedidos();
        }

        private void RbtEntregas_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 3;
            preencherPedidos();
        }

        private void BtnNovoPedido_Click(object sender, EventArgs e)
        {
            frmNovoPedido frm = new frmNovoPedido(1,0);
            frm.ShowDialog();
        }

        private void DtpDataPedido_ValueChanged(object sender, EventArgs e)
        {
            preencherPedidos();
        }

        private void DgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvPedidos.Columns["colCancelar"].Index && dgvPedidos.Rows.Count > 0 && e.RowIndex != dgvPedidos.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Deseja cancelar esse pedido?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        frmInputBoxJCS frm = new frmInputBoxJCS("Informe o motivo do cancelamento.", 3);
                        frm.ShowDialog();

                        cancelarPedido(int.Parse(dgvPedidos["colPedido", e.RowIndex].Value.ToString()), frm.retorno);

                        preencherPedidos();
                    }
                }
            }

            if (e.RowIndex > -1 && e.ColumnIndex == dgvPedidos.Columns["colEditar"].Index && dgvPedidos.Rows.Count > 0 && e.RowIndex != dgvPedidos.Rows.Count)
            {
                frmNovoPedido frm = new frmNovoPedido(2, int.Parse(dgvPedidos["colPedido", e.RowIndex].Value.ToString()));
                frm.ShowDialog();

                preencherPedidos();
            }

            if (e.RowIndex > -1 && e.ColumnIndex == dgvPedidos.Columns["colPagar"].Index && dgvPedidos.Rows.Count > 0 && e.RowIndex != dgvPedidos.Rows.Count)
            {
                frmPagamentos frm = new frmPagamentos(int.Parse(dgvPedidos["colPedido", e.RowIndex].Value.ToString()), dgvPedidos["colDescricao", e.RowIndex].Value.ToString(), situacao);
                frm.ShowDialog();

                preencherPedidos();
            }
        }

        private void cancelarPedido(int pPedido, string pDescricao)
        {
            sqlAux.updateSituacaoPedido(pPedido, " - CANCELADO: " + pDescricao, 0);
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }
        
        private void FrmPedidos_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmPedidos_MouseEnter;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            preencherPedidos();
        }
    }
}
