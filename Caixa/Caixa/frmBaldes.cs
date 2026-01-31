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

namespace Caixa.Caixa
{
    public partial class frmBaldes : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
       

        public frmBaldes()
        {
            InitializeComponent();
            cboFiltro.SelectedIndex = 2;
            preencherGrid();//STATUS PARA APARECER TODOS OS BALDES
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                try
                {
                    string nome = txtNome.Text;
                    string end = txtEnd.Text;
                    string tel = txtTelefone.Text;
                    string balde = cboBalde.SelectedItem.ToString();

                    int colher = string.IsNullOrEmpty(txtColher.Text) ? 0 : int.Parse(txtColher.Text);

                    auxSQL.insertBalde(nome,end,tel,balde,colher);


                    MessageBox.Show("Balde salvo na base de dados!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    preencherGrid();
                    limpaCampos();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Contate o suporte para verificar o erro: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique se os campos estão preenchidos corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpaCampos()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtTelefone.Text = "";
            cboBalde.SelectedIndex = -1;
            txtColher.Text = "";
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtTelefone.Text))
                return false;
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                return false;
            if (string.IsNullOrEmpty(txtEnd.Text.Trim()))
                return false;
            if (cboBalde.SelectedIndex < 0)
                return false;
            if (cboBalde.SelectedIndex == 3)
                if (string.IsNullOrEmpty(txtColher.Text.Trim()))
                    return false;

            return true;
        }

        private void preencherGrid()
        {
            DataTable dt;
            if (cboFiltro.SelectedIndex == 2)
                dt = auxSQL.buscaBaldes(-1);
            else
                dt = auxSQL.buscaBaldes(cboFiltro.SelectedIndex);
            dgvBaldes.DataSource = dt;
        }

        private void CboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void DgvBaldes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBaldes.Columns["colEditar"].Index && dgvBaldes.Rows.Count > 0 && e.RowIndex >= 0)
            {
                string nome = dgvBaldes.Rows[e.RowIndex].Cells["colNome"].Value.ToString();
                string balde = dgvBaldes.Rows[e.RowIndex].Cells["colBalde"].Value.ToString();

                if (bool.Parse(dgvBaldes.Rows[e.RowIndex].Cells["colEntregue"].Value.ToString()) == true)
                {

                    MessageBox.Show(nome + " já devolveu o balde de " + balde, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string descricao = nome + " está devolvendo o balde de " + balde + " ?";

                DialogResult result = MessageBox.Show(descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    descricao = nome + " devolveu o balde de " + balde + "!!!";
                    auxSQL.updateBaldes(int.Parse(dgvBaldes.Rows[e.RowIndex].Cells["colID"].Value.ToString()), 1);
                    MessageBox.Show(descricao, "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    preencherGrid();
                }

            }
        }

        private void DgvBaldes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //VALOR EM ABERTO
            if (dgvBaldes.Columns[e.ColumnIndex].Name == "colEntregue")
            {
                DataGridViewRow row = dgvBaldes.Rows[e.RowIndex];
                if (bool.Parse(e.Value.ToString()) == false)
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FBEFEF");
                else
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0F8E0");
            }

        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelefone.Text))
            {
                txtTelefone.TipoCampo = "STRING";
                txtTelefone.Text =  AplicarMascaraTelefone(txtTelefone.Text);
                txtTelefone.TipoCampo = "INTEIRO";

                if (txtTelefone.Text.Length < 14)
                {
                    if (txtTelefone.Text.Length == 13)
                    {
                        DialogResult result = MessageBox.Show("O numero informado é de telefone fixo?", "Telefone Fixo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (result == DialogResult.No)
                            {
                                MessageBox.Show("O formato do numero telefonico está incorreto. Por favor informe DD + numero com o 9 antes, se for celular.", "Formato (34)9 9999-9999", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtTelefone.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("O formato do numero telefonico está incorreto. Por favor informe DD + numero com o 9 antes, se for celular.", "Formato (34)9 9999-9999", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTelefone.Text = "";
                    }
                }
            }
        }

        string AplicarMascaraTelefone(string strNumero)
        {
            // por omissão tem 10 ou menos dígitos
            string strMascara = "{0:(00)0000-0000}";
            // converter o texto em número
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";
            if (strNumero.Length == 9)
                strMascara = "{0:00000-0000}";
            if (strNumero.Length == 8)
                strMascara = "{0:0000-0000}";

            return string.Format(strMascara, lngNumero);
        }
    }
}
