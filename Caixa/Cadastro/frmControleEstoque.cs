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
    public partial class frmControleEstoque : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private string produto, descricao, unidade;
        private int estoque, estoqueIdeal, qtEnvFor;
        private double custo;

        private void DgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstoque.Columns["colAlterar"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja alterar o valor de custo do produto ' + " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmInputBoxJCS frm = new frmInputBoxJCS("Informe o novo valor.", 2);
                    frm.ShowDialog();
                    if (!string.IsNullOrEmpty(frm.retorno))
                    {
                        auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), double.Parse(frm.retorno));
                        preencherCampos();
                    }
                }
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colDesativar"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja desativar o ' + " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), 0, 0);
                    preencherCampos();
                }
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colAumentarEstoque"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja adicionar  + " + dgvEstoque["colQtEntregueFornecedor", e.RowIndex].Value.ToString() + " ao estoque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), 0, -1, 1);
                    preencherCampos();
                }
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colDiminuirEstoque"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja subtrair 1 - " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ao estoque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), 0, -1, -1);
                    preencherCampos();
                }
            }




        }

        public frmControleEstoque()
        {
            InitializeComponent();
            preencherCampos();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                auxSQL.insertControleEstoque(produto, descricao, estoque, unidade, estoqueIdeal, qtEnvFor, custo, true);
                MessageBox.Show("Produto criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                preencherCampos();
            }
        }

        private void limparCampos()
        {
            this.limpar(txtCusto);
            this.limpar(txtDescricao);
            this.limpar(txtEstoqueIdeaal);
            this.limpar(txtProduto);
            this.limpar(txtQtEntregueFornecedor);
            this.limpar(txtQTEstoque);
            this.limpar(txtUnidadeMedida);
        }
        private void preencherCampos()
        {
            DataTable dt = auxSQL.buscaControleEstoque(0);
            dgvEstoque.DataSource = dt;
        }

        private bool validaCampos()
        {
            produto = txtProduto.Text;
            descricao = txtDescricao.Text;
            unidade = txtUnidadeMedida.Text;
            estoque = int.Parse(txtQTEstoque.Text);
            estoqueIdeal = int.Parse(txtEstoqueIdeaal.Text);
            qtEnvFor = int.Parse(txtQtEntregueFornecedor.Text);
            custo = double.Parse(txtCusto.Text.Replace("R$",""));

            if (estoque <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo de estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (estoqueIdeal <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo de estoque ideal.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (qtEnvFor <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo de estoque ideal.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (custo <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo de custo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(unidade))
            {
                MessageBox.Show("Por favor, preencha o campo de unidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
