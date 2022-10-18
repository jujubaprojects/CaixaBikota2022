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
        ToolStrip tStrip = new ToolStrip();
        private SQL.SQL auxSQL = new SQL.SQL();

        int id = 0;
        string produto = "";
        int tipo = 0, qtDesc = 0, exibirApp = 0, qtSubEstoque = 0;
        double valor = 0;

        public frmCadastroProduto()
        {

            tStrip = toolStrip1;
            tStrip.Click += new EventHandler(toolStripNovoJCS_Click);
            tStrip.Click += new EventHandler(toolStripDeletarJCS_Click);
            tStrip.Click += new EventHandler(toolStripSalvarJCS_Click);
            tStrip.Click += new EventHandler(toolStripEditarJCS_Click);
            tStrip.Click += new EventHandler(toolStripVoltarJCS_Click);

            InitializeComponent();


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

        public void toolStripNovoJCS_Click(object sebder, EventArgs e)
        {
            if (clickBtns.Equals("Novo"))
            {
                if (camposPreenchidos(this, "Novo"))
                {

                }
            }
        }
        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {

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
        public void toolStripDeletarJCS_Click(object sebder, EventArgs e)
        {
            if (clickBtns.Equals("Deletar"))
            {
            }

            }
        public void toolStripSalvarJCS_Click(object sebder, EventArgs e)
        {
            if (clickBtns.Equals("Novo"))
            {
                if (camposPreenchidos(this, "Salvar"))
                {
                    validaCampos();
                    DialogResult result = MessageBox.Show("Deseja salvar o novo produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            auxSQL.insertProduto(produto, tipo, valor, qtDesc, exibirApp, qtSubEstoque);
                        }
                    }
                }
            }
        }
        public void toolStripEditarJCS_Click(object sebder, EventArgs e)
        {
            if (clickBtns.Equals("Editar"))
            {
                DialogResult result = MessageBox.Show("Deseja editar o produto " + produto + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.No)
                    {
                        toolStripVoltarJCS_Click(new object(), new EventArgs());
                    }
                }
            }
        }

        private void preencherCampos()
        {
            dgvProdutos.DataSource = auxSQL.retornaDataTable("SELECT ID, P.DESCRICAO, C.DESCRICAO TIPO, VALOR, QT_DESCRICAO, P.EXIBIR_APP, QT_SUB_ESTOQUE FROM PRODUTO P JOIN CATEGORIA C ON (P.TIPO = C.TIPO)");

        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvProdutos["colID", e.RowIndex].Value.ToString());
            produto = dgvProdutos["colDescricao", e.RowIndex].Value.ToString();
        }
    }
}
