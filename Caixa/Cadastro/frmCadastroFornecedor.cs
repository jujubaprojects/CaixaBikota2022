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
    public partial class frmCadastroFornecedor : frmCadastroJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        int id = 0;
        string nome, nomeFantasia, IE, fone, cnpj, end,bairro, cidade, estado, numero, nomeForm;
        int cep;

        public frmCadastroFornecedor()
        {

            //btnNovo = toolStripNovoJCS;
            btnVoltar = toolStripVoltarJCS;
            btnEditar = toolStripEditarJCS;
            btnDeletar = toolStripDeletarJCS;
            btnSalvar = toolStripSalvarJCS;


            //tStrip.click += new EventHandler(toolStripNovoJCS_Click);
            //btnNovo.Click += new EventHandler(toolStripNovoJCS_Click);
            btnDeletar.Click += new EventHandler(toolStripDeletarJCS_Click);
            btnSalvar.Click += new EventHandler(toolStripSalvarJCS_Click);
            btnEditar.Click += new EventHandler(toolStripEditarJCS_Click);
            btnVoltar.Click += new EventHandler(toolStripVoltarJCS_Click);

            InitializeComponent();
            nomeForm = this.Text;

            preencherCampos();
            if (dgvFornecedores.RowCount > 0)
            {
                id = int.Parse(dgvFornecedores["colID", 0].Value.ToString());
                nome = dgvFornecedores["colNome", 0].Value.ToString();
            }
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            //cboExibirApp.SelectedIndex = 0;
            //cboTipo.SelectedIndex = 0;
        }

        private void validaCampos()
        {
            cnpj = txtCNPJ.Text;
            nome = txtNome.Text;
            IE = txtIE.Text;
            fone = txtFone.Text;
            nomeFantasia = txtNomeFantasia.Text;
            cep = int.Parse(txtCEP.Text);
            end = txtEnd.Text;
            numero = txtNumero.Text;
            bairro = txtBairro.Text;
            cidade = cboCidade.Text.ToString();
            estado = cboEstado.Text.ToString();
        }
        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {

        }

        private void DgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvFornecedores["colID", e.RowIndex].Value.ToString());
                nome = dgvFornecedores["colNome", e.RowIndex].Value.ToString();
            }
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {

            if (clickBtns.Equals("Novo"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar o novo Fornecedor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertFornecedor(cnpj, nome, IE, fone, nomeFantasia, cep, end, numero, bairro, cidade, estado);
                        preencherCampos();
                    }
                }
            }
            else if (clickBtns.Equals("Editar"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as alterações do Fornecedor - " + nome + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.updateFornecedor(id, cnpj, nome, IE, fone, nomeFantasia, cep, end, numero, bairro, cidade, estado);
                        MessageBox.Show("Fornecedor alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
            }


        }
        public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja editar o Fornecedor " + nome + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.No)
                {
                    toolStripVoltarJCS_Click(sender, e);

                    this.toolStripNovoJCS.Enabled = true;
                    this.toolStripEditarJCS.Enabled = true;
                    this.toolStripSalvarJCS.Enabled = false;
                    this.toolStripDeletarJCS.Enabled = false;
                    this.toolStripVoltarJCS.Enabled = false;
                    this.Text = nomeForm + " (Voltar)";
                    clickBtns = "Voltar";
                    botaoRetorno = true;
                }
                else
                {
                    DataTable dt = auxSQL.buscaFornecedor(id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtBairro.Text = dt.Rows[0]["END_BAIRRO"].ToString();
                    txtCEP.Text = dt.Rows[0]["CEP"].ToString();
                    txtCNPJ.Text = dt.Rows[0]["CPF_CNPJ"].ToString();
                    txtEnd.Text = dt.Rows[0]["END_RUA"].ToString();
                    txtFone.Text = dt.Rows[0]["FONE"].ToString();
                    txtIE.Text = dt.Rows[0]["IE"].ToString();
                    txtNome.Text = dt.Rows[0]["NOME"].ToString();
                    txtNomeFantasia.Text = dt.Rows[0]["NOME_FANTASIA"].ToString();
                    txtNumero.Text = dt.Rows[0]["END_NUM"].ToString();
                    cboCidade.Text = dt.Rows[0]["END_CIDADE"].ToString();
                    cboEstado.Text = dt.Rows[0]["END_UF"].ToString();
                }

            }
        }

        private void preencherCampos()
        {
            dgvFornecedores.DataSource = auxSQL.retornaDataTable("SELECT ID, CPF_CNPJ, NOME, IE, FONE, NOME_FANTASIA, CEP, UPPER(CONCAT(END_RUA, ' - Nº: ', END_NUM,' / ', END_BAIRRO)) AS END_RUA, UPPER(CONCAT(END_CIDADE, '/', END_UF)) END_CIDADE_UF FROM FORNECEDOR");

        }
    }
}
