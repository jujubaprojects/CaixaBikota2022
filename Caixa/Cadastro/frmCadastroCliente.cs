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

namespace Caixa.Cadastro
{
    public partial class frmCadastroCliente : FormJCS
    {
        private string nome, endereco, contato;
        private int status = 0;
        private int tipoOperacao = 0; //0 = Cadastro; 1 = Alteração;
        private int id = 0;

        private SQL.SQL auxSQL = new SQL.SQL();

        public frmCadastroCliente()
        {
            InitializeComponent();
            preencherGrid();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            endereco = txtEnd.Text;
            contato = txtContato.Text;
            status = cboStatus.SelectedIndex;
            if (validaCampos())
            {
                if (tipoOperacao == 0)
                {
                    auxSQL.insertCliente(nome, endereco, contato, status);
                    MessageBox.Show("Cliente salvo na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tipoOperacao == 1)
                {
                    auxSQL.updateCliente(id,nome, endereco, contato, status);
                    MessageBox.Show("Cliente alterado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampos();
                }
                        
                preencherGrid();
            }

        }

        private void limpaCampos ()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtContato.Text = "";
            tipoOperacao = 0;
            btnSalvar.Text = "Adicionar Cadastro";
        }
        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["colEditar"].Index && dgvClientes.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja alterar as informações do Cliente ' + " + dgvClientes["colNome",e .RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    id = int.Parse(dgvClientes["colID", e.RowIndex].Value.ToString());
                    tipoOperacao = 1;
                    txtNome.Text = dgvClientes["colNome", e.RowIndex].Value.ToString();
                    txtContato.Text = dgvClientes["colContato", e.RowIndex].Value.ToString();
                    txtEnd.Text = dgvClientes["colEnd", e.RowIndex].Value.ToString();
                    cboStatus.SelectedIndex = bool.Parse(dgvClientes["colStatus", e.RowIndex].Value.ToString()) ? 1 : 0;

                    btnSalvar.Text = "Alterar Cadastro";

                }

            }
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, verifque o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Por favor, verifique o endereço do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(contato))
            {
                MessageBox.Show("Por favor, verifique o contato do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (status < 0)
            {
                MessageBox.Show("Por favor, verifique o status do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void preencherGrid()
        {
            dgvClientes.DataSource = auxSQL.buscaClienteID(0);
        }
    }
}
