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
        private int tipoOperacao = 0, id = 0;
        private SQL.SQL auxSQL = new SQL.SQL();
        private string produto, descricao, unidade, fornecedor;
        private int estoque, estoqueIdeal, qtEnvFor;
        private double custo;
        private DateTime dataEntrega;

        private void DgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEstoque.Columns["colAlterar"].Index && dgvEstoque.Rows.Count > 0)
            {
                frmControleEstoque frmce = new frmControleEstoque(2, int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()));
                frmce.ShowDialog();
                preencherCampos();

                //DialogResult result = MessageBox.Show("Deseja alterar o valor de custo do produto ' + " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                //    frmInputBoxJCS frm = new frmInputBoxJCS("Informe o novo valor.", 2);
                //    frm.ShowDialog();
                //    if (!string.IsNullOrEmpty(frm.retorno))
                //    {
                //        frmControleEstoque frmce = new frmControleEstoque(2);
                //        frmce.ShowDialog();
                //        //auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), double.Parse(frm.retorno));
                //        //auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()),0,0, double.Parse(frm.retorno), null,null,-1,0);
                //        preencherCampos();
                //    }
                //}
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colDesativar"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja desativar o ' + " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()));
                    preencherCampos();
                }
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colAumentarEstoque"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja adicionar  + " + dgvEstoque["colQtEntregueFornecedor", e.RowIndex].Value.ToString() + " ao estoque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()),"", 0, 0, 0,0, "","", "", -1, 1);
                    preencherCampos();
                }
            }
            else if (e.ColumnIndex == dgvEstoque.Columns["colDiminuirEstoque"].Index && dgvEstoque.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja subtrair 1 - " + dgvEstoque["colProduto", e.RowIndex].Value.ToString() + " ao estoque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.updateControleEstoqueCusto(int.Parse(dgvEstoque["colID", e.RowIndex].Value.ToString()), "", 0, 0, 0, 0,"", "", "", -1, -1);
                    preencherCampos();
                }
            }




        }

        public frmControleEstoque(int pOperacao = 1, int pID = 0)
        {
            tipoOperacao = pOperacao;
            id = pID;
            InitializeComponent();
            preencherCampos();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (tipoOperacao == 1)
                {
                    //auxSQL.insertControleEstoque(produto, descricao, estoque, unidade, estoqueIdeal, qtEnvFor, custo, fornecedor, dataEntrega, true);
                    MessageBox.Show("Produto criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    auxSQL.updateControleEstoqueCusto(id,produto, estoque, estoqueIdeal, qtEnvFor, custo, unidade, fornecedor, dataEntrega.ToString(), -1, 0);
                    //auxSQL.updateControleEstoqueCusto(id, estoque, estoqueIdeal, custo, fonecedor);
                    MessageBox.Show("Produto criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

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

            if (tipoOperacao == 2)
            {
                btnAdd.Text = "Alterar";
                this.Text = "Alteração de Estoque";

                if (id > 0)
                {
                    DataTable dtInf = auxSQL.buscaControleEstoque(id);
                    if (dtInf.Rows.Count > 0)
                    {
                        txtCusto.Text = dtInf.Rows[0]["CUSTO"].ToString();
                        txtDescricao.Text = dtInf.Rows[0]["DESCRICAO"].ToString();
                        txtEstoqueIdeaal.Text = dtInf.Rows[0]["QT_ESTOQUE_IDEAL"].ToString();
                        txtFornecedor.Text = dtInf.Rows[0]["FORNECEDOR"].ToString();
                        txtProduto.Text = dtInf.Rows[0]["PRODUTO"].ToString();
                        txtQtEntregueFornecedor.Text = dtInf.Rows[0]["QT_ENTREGUE_FORNECEDOR"].ToString();
                        txtQTEstoque.Text = dtInf.Rows[0]["QT_ESTOQUE"].ToString();
                        txtUnidadeMedida.Text = dtInf.Rows[0]["UNIDADE_MEDIDA"].ToString();
                        dtpDataEntrega.Text = dtInf.Rows[0]["DATA_ENTREGA"].ToString();
                    }
                }
            }
            else
            {
                btnAdd.Text = "Adicionar";
                this.Text = "Criação de Estoque";
            }
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
            fornecedor = txtFornecedor.Text;
            dataEntrega = DateTime.Parse(dtpDataEntrega.Text);

            if (estoque < 0)
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
                MessageBox.Show("Por favor, preencha o campo de quantidade enviada pelo fornecedor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(fornecedor))
            {
                MessageBox.Show("Por favor, preencha o campo de fornecedor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
