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
    public partial class frmCadastroSubEstoque : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private bool produtoVal = false, controleVal = false;

        private void BtnBuscaProdutoFinal_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT P.ID, P.DESCRICAO, C.DESCRICAO CATEGORIA ");
            sql.Append("FROM PRODUTO P ");
            sql.Append("JOIN CATEGORIA C ON(C.TIPO = P.TIPO) ");
            sql.Append("WHERE P.EXIBIR_APP = 1 ");
            sql.Append("ORDER BY DESCRICAO ");

            frmBusca frm = new frmBusca(sql, "Controle Estoque");
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIDProd.Text = frm.retorno["ID"].ToString();
                txtDescProduto.Text = frm.retorno["DESCRICAO"].ToString();
                produtoVal = true;
            }
            else
            {
                txtIDProd.Text = "";
                txtDescProduto.Text = "";
                produtoVal = false;
            }
        }

        private void BtnLinkar_Click(object sender, EventArgs e)
        {
            if (controleVal && produtoVal && !string.IsNullOrEmpty(txtQtSub.Text))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM SUB_ESTOQUE ");
                sql.Append("WHERE PRODUTO = " + int.Parse(txtIDProd.Text));
                sql.Append(" and CONTROLE_ESTOQUE = " + int.Parse(txtIdEstoque.Text));
                DataTable dt = auxSQL.retornaDataTable(sql.ToString());

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Este link já foi cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if ()
                auxSQL.insertLinkProdutoFinalxControleEstoque(int.Parse(txtIDProd.Text), int.Parse(txtIdEstoque.Text), int.Parse(txtQtSub.Text));
                MessageBox.Show("Link criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preencherCampos();
                limparCampos();
            }
            else
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void limparCampos()
        {
            txtDescEstoque.Text = "";
            txtDescProduto.Text = "";
            txtIdEstoque.Text = "";
            txtIDProd.Text = "";
            txtQtSub.Text = "";
        }

        private void BtnBuscaControlEstq_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, QT_ESTOQUE, QT_ESTOQUE_IDEAL FROM CONTROLE_ESTOQUE WHERE STATUS = 1 ORDER BY DESCRICAO");

            frmBusca frm = new frmBusca(sql, "Controle Estoque");
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIdEstoque.Text = frm.retorno["ID"].ToString();
                txtDescEstoque.Text = frm.retorno["DESCRICAO"].ToString();
                controleVal = true;
            }
            else
            {
                txtIdEstoque.Text = "";
                txtDescEstoque.Text = "";
                controleVal = false;
            }
        }

        public frmCadastroSubEstoque()
        {
            InitializeComponent();

            preencherCampos();
        }

        private void DgvSubEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSubEstoque.Columns["colExcluir"].Index && dgvSubEstoque.Rows.Count > 0 && e.RowIndex > -1)
            {
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("Deseja excluir o link do \nProduto: " + dgvSubEstoque["colDescProd", e.RowIndex].Value.ToString());
                mensagem.Append("\nEstoque: " + dgvSubEstoque["colDescEst", e.RowIndex].Value.ToString());
                DialogResult result = MessageBox.Show(mensagem.ToString(), "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.excluirLinkProdutoFinalxControleEstoque(int.Parse(dgvSubEstoque["colID", e.RowIndex].Value.ToString()));
                    preencherCampos();
                }

            }
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT S.ID, P.ID COD_PROD, P.DESCRICAO DESC_PROD, CE.ID COD_EST, CE.DESCRICAO DESC_EST, S.QT_SUB ");
            sql.Append("FROM SUB_ESTOQUE S ");
            sql.Append("JOIN CONTROLE_ESTOQUE CE ON(CE.ID = S.CONTROLE_ESTOQUE) ");
            sql.Append("JOIN PRODUTO P ON(P.ID = S.PRODUTO) ");
            sql.Append("ORDER BY DESC_PROD");
            dgvSubEstoque.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }
    }
    
}
