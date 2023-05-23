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
        private string descricao;
        private bool status = true;
        private int qtEstoque, qtEstoqueIdeal;

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
            //preencherCampos();

            cboStatus.SelectedIndex = 1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (tipoOperacao == 1)
                {
                    auxSQL.insertControleEstoque(descricao, qtEstoque, qtEstoqueIdeal, status );
                    MessageBox.Show("Produto criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    auxSQL.updateControleEstoque(id, descricao, qtEstoque, qtEstoqueIdeal, status);
                    MessageBox.Show("Produto criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                limparCampos();
                preencherCampos();
            }
        }

        private void limparCampos()
        {
            this.limpar(txtDescricao);
            this.limpar(txtEstoqueIdeaal);
            this.limpar(txtQTEstoque);
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void preencherCampos()
        {
            DataTable dt = auxSQL.buscaControleEstoque(0,cboStatus.SelectedIndex);
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
                        txtDescricao.Text = dtInf.Rows[0]["DESCRICAO"].ToString();
                        txtEstoqueIdeaal.Text = dtInf.Rows[0]["QT_ESTOQUE_IDEAL"].ToString();
                        txtQTEstoque.Text = dtInf.Rows[0]["QT_ESTOQUE"].ToString();
                        chkAtivo.Checked = dt.Rows[0]["STATUS"].ToString().Equals("True") ? true : false;
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
            descricao = txtDescricao.Text;
            qtEstoque = int.Parse(txtQTEstoque.Text);
            qtEstoqueIdeal = int.Parse(txtEstoqueIdeaal.Text);

            if (qtEstoque < 0)
            {
                MessageBox.Show("Por favor, preencha o campo de estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (qtEstoqueIdeal <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo de estoque ideal.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Por favor, preencha o campo de descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
