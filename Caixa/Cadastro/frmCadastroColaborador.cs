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
    public partial class frmCadastroColaborador : frmCadastroJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        int id = 0, status = 0;
        string nome = "", cpf = "", logradouro = "", numero = "", bairro = "", cidade = "", estado = "", contato = "";
        string email = "", beneficios = "", nomeForm = "";
        DateTime dtNascimento, dtInicio, dtSaida;
        double salario;
        
        public frmCadastroColaborador()
        {

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
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            //cboExibirApp.SelectedIndex = 0;
            //cboTipo.SelectedIndex = 0;
        }

        //private void validaCampos()
        //{
        //    produto = txtDescricao.Text;
        //    tipo = int.Parse(auxSQL.buscaCategoria(cboTipo.SelectedItem.ToString()).Rows[0]["TIPO"].ToString());
        //    qtDesc = int.Parse(txtQtDesc.Text);
        //    exibirApp = cboExibirApp.SelectedIndex;
        //    qtSubEstoque = int.Parse(txtQtSubEstoque.Text);
        //    valor = double.Parse(txtValor.Text.Replace("R$", ""));
        //}
        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {

        }
        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Confira os campos, está faltando informações para preencher!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nome = txtNome.Text;
            cpf = txtCPF.Text;
            logradouro = txtLogradouro.Text;
            numero = txtNumero.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            estado = txtEstado.Text;
            contato = txtContato.Text;
            email = txtEmail.Text;
            beneficios = txtBeneficios.Text;
            dtNascimento = dtpNascimento.Value;
            dtInicio = dtpInicio.Value;
            dtSaida = dtpSaida.Value;
            salario = double.Parse(txtSalario.Text);
            status = cboStatus.SelectedIndex == 1 ? 1 : 0;

            if (clickBtns.Equals("Novo"))
            {

                DialogResult result = MessageBox.Show("Deseja salvar o novo produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertColaborador(nome, cpf, logradouro, numero, bairro, cidade, estado, contato, email, dtNascimento, dtInicio, DateTime.Parse("01/01/2050"), salario, beneficios, 1);
                        preencherCampos();
                    }
                }                   
            }
            else if (clickBtns.Equals("Editar"))
            {
                //validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as informações de " + nome + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.updateColaborador(id, nome, cpf, logradouro, numero, bairro, cidade, estado, contato, email, dtNascimento, dtInicio, dtSaida, salario, beneficios, status);
                        //MessageBox.Show("Produto alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //preencherCampos();
                    }
                }
            }


        }
        public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja alterar as informações de " + nome + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    DataTable dt = auxSQL.buscaColaborador(id);

                    txtID.Text = dt.Rows[0]["ID"].ToString();

                    txtBairro.Text = dt.Rows[0]["BAIRRO"].ToString();
                    txtBeneficios.Text = dt.Rows[0]["BENEFICIOS"].ToString();
                    txtCidade.Text = dt.Rows[0]["CIDADE"].ToString();
                    txtContato.Text = dt.Rows[0]["CONTATO"].ToString();
                    txtCPF.Text = dt.Rows[0]["CPF"].ToString();
                    txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                    txtEstado.Text = dt.Rows[0]["ESTADO"].ToString();
                    txtLogradouro.Text = dt.Rows[0]["LOGRADOURO"].ToString();
                    txtNome.Text = dt.Rows[0]["NOME"].ToString();
                    txtSalario.Text = dt.Rows[0]["SALARIO"].ToString();

                    cboStatus.SelectedIndex = dt.Rows[0]["STATUS"].ToString().Equals("True") ? 1 : 0;
                    dtpInicio.Text = dt.Rows[0]["DT_INICIO"].ToString();
                    dtpNascimento.Text = dt.Rows[0]["DT_NASCIMENTO"].ToString();
                    dtpSaida.Text = dt.Rows[0]["DT_SAIDA"].ToString();
                }

            }
        }
        private void preencherCampos()
        {
            dgvColaboradores.DataSource = auxSQL.retornaDataTable("SELECT ID, NOME, CPF, END_LOGRA, END_NUM, END_BAIRRO, END_CIDADE, END_ESTADO, CONTATO, EMAIL, DT_NASCIMENTO, DT_ENTRADA, DT_SAIDA, VL_SALARIO, BENEFICIOS, ATIVO FROM COLABORADOR");
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvColaboradores["colID", e.RowIndex].Value.ToString());
                nome = dgvColaboradores["colNome", e.RowIndex].Value.ToString();
            }

        }

        private bool validarCampos ()
        {
            if (string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtBeneficios.Text) || string.IsNullOrEmpty(txtCidade.Text)
                 || string.IsNullOrEmpty(txtContato.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtEmail.Text)
                  || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtLogradouro.Text) || string.IsNullOrEmpty(txtNome.Text)
                   || string.IsNullOrEmpty(txtSalario.Text) || cboStatus.SelectedIndex == 0)
                return false;

            return true;
        }


    }
}
