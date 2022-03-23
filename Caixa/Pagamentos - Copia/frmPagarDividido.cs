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
    public partial class frmPagarDividido : FormJCS
    {
        private string pedidosID;
        private double vlTotal;
        public double vlRecebido = 0;
        private bool forcouFechar = true;
        private bool controleEsc = true;

        public frmPagarDividido(string pIDs, double pVlTotal)
        {
            InitializeComponent();

            this.pedidosID = pIDs;
            this.vlTotal = Math.Round(pVlTotal, 2);

            txtVlTotal.Text = pVlTotal.ToString();
            txtVlRecebido.Text = pVlTotal.ToString();
        }

        private void TxtQtDivisao_TextChanged(object sender, EventArgs e)
        {
            vlRecebido = 0;
            if (!string.IsNullOrEmpty(txtQtDivisao.Text)  && int.Parse(txtQtDivisao.Text.ToString()) > 0)
            {
                double vlAux = 0;

                vlRecebido = Math.Round(vlTotal / int.Parse(txtQtDivisao.Text.ToString()), 2);
                vlAux = Math.Abs(Math.Round(Math.Round(vlTotal / int.Parse(txtQtDivisao.Text.ToString()), 1) - vlRecebido, 2));

                //if (vlAux < 0.05 && vlAux > 0)
                //    vlRecebido = Math.Round(vlTotal / int.Parse(txtQtDivisao.Text.ToString()), 1) + 0.05;
                //else if (vlAux > 0.05 && vlAux > 0)
                //    vlRecebido = Math.Round(vlTotal / int.Parse(txtQtDivisao.Text.ToString()), 1);


                txtVlRecebido.Text = vlRecebido.ToString();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtDivisao.Text) || !string.IsNullOrEmpty(txtVlRecebido.Text.ToString()))
            {
                    vlRecebido = double.Parse(txtVlRecebido.Text.ToString());
                //if (vlRecebido > vlTotal)
                //{
                //    MessageBox.Show("Valor Recebido maior que o Total!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //if (txtVlRecebido.Text == txtVlTotal.Text)
                //{
                //    MessageBox.Show("Valor Recebido não pode ser o valor informado!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                forcouFechar = false;
                this.Close();
            }
            else
                MessageBox.Show("Informe a quantidade dividida ou o valor manual!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            forcouFechar = false;
            vlRecebido = 0;
            this.Close();
        }

        private void FrmPagarDividido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (forcouFechar)
                vlRecebido = 0;
        }

        private void TxtVlRecebido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVlRecebido.Text))
                txtQtDivisao.Text = "";
        }

        private void FrmPagarDividido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmPagarDividido_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmPagarDividido_MouseEnter;
        }
    }
}
