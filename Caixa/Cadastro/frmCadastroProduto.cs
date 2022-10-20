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

namespace Caixa.Cadastro
{
    public partial class frmCadastroProduto : frmCadastroJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        int id = 0;
        string produto = "", nomeForm;
        int tipo = 0, qtDesc = 0, exibirApp = 0, qtSubEstoque = 0;
        double valor = 0;

        public frmCadastroProduto()
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
            if (dgvProdutos.RowCount > 0)
            {
                id = int.Parse(dgvProdutos["colID", 0].Value.ToString());
                produto = dgvProdutos["colDescricao", 0].Value.ToString();
            }


            DataTable dt = auxSQL.buscaCategoria("");
            for (int i = 0; i < dt.Rows.Count; i++)
                cboTipo.Items.Add(dt.Rows[i]["DESCRICAO"].ToString());
            cboTipo.SelectedIndex = 0;
            cboExibirApp.SelectedIndex = 1;
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            cboExibirApp.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
        }

        private void validaCampos()
        {
            produto = txtDescricao.Text;
            tipo = int.Parse(auxSQL.buscaCategoria(cboTipo.SelectedItem.ToString()).Rows[0]["TIPO"].ToString());
            qtDesc = int.Parse(txtQtDesc.Text);
            exibirApp = cboExibirApp.SelectedIndex;
            qtSubEstoque = int.Parse(txtQtSubEstoque.Text);
            valor = double.Parse(txtValor.Text.Replace("R$", ""));
        }
        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {

        }
        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {

            if (clickBtns.Equals("Novo"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar o novo produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertProduto(produto, tipo, valor, qtDesc, exibirApp, qtSubEstoque);
                        preencherCampos();
                    }
                }
            }
            else if (clickBtns.Equals("Editar"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as alterações do produto - " + produto + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.updateProduto(id, produto, tipo, valor, qtDesc, exibirApp, qtSubEstoque);
                        MessageBox.Show("Produto alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
            }


        }
        public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja editar o produto " + produto + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    DataTable dt = auxSQL.buscaProduto(id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    txtQtDesc.Text = dt.Rows[0]["QT_DESCRICAO"].ToString();
                    txtQtSubEstoque.Text = dt.Rows[0]["QT_SUB_ESTOQUE"].ToString();
                    txtValor.Text = dt.Rows[0]["VALOR"].ToString();
                    cboExibirApp.SelectedIndex = dt.Rows[0]["EXIBIR_APP"].ToString().Equals("True") ? 1 : 0;
                    cboTipo.SelectedItem = auxSQL.buscaCategoria(int.Parse(dt.Rows[0]["TIPO"].ToString())).Rows[0]["DESCRICAO"].ToString();
                }

            }
        }

        private void preencherCampos()
        {
            dgvProdutos.DataSource = auxSQL.retornaDataTable("SELECT ID, P.DESCRICAO, C.DESCRICAO TIPO, VALOR, QT_DESCRICAO, P.EXIBIR_APP, QT_SUB_ESTOQUE FROM PRODUTO P JOIN CATEGORIA C ON (P.TIPO = C.TIPO)");

        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvProdutos["colID", e.RowIndex].Value.ToString());
                produto = dgvProdutos["colDescricao", e.RowIndex].Value.ToString();
            }

        }
    }
}
