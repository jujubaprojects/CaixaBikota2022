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

namespace Caixa.Estoque
{
    public partial class frmLinkProdNFFornecedor : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private bool produtoVal = false, materiaVal = false, fornecedor = false;
        public frmLinkProdNFFornecedor()
        {
            InitializeComponent();

            preencherCampos();
        }



        private void BtnLinkar_Click(object sender, EventArgs e)
        {
            if (materiaVal && produtoVal && fornecedor && !string.IsNullOrEmpty(txtQtCaixa.Text))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM NFPROD_CONTROLESTQ ");
                sql.Append("WHERE COD_PROD_NF = " + int.Parse(txtIDProd.Text));
                sql.Append(" and FOR_ID = " + int.Parse(txtIDFornecedor.Text));
                sql.Append(" and COD_CONTRESTQ = " + int.Parse(txtIdEstoque.Text));
                DataTable dt = auxSQL.retornaDataTable(sql.ToString());

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Este link já foi cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if ()
                auxSQL.insertLinkNFxProdXfor(int.Parse(txtIDProd.Text), int.Parse(txtIDFornecedor.Text), int.Parse(txtIdEstoque.Text), int.Parse(txtQtCaixa.Text));
                MessageBox.Show("Link criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preencherCampos();
                limparCampos();
            }
            else
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparCampos()
        {
            this.limpar(txtProduto);
            this.limpar(txtDescricaoEstoque);
            this.limpar(txtIdEstoque);
            this.limpar(txtIDProd);
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
                txtDescricaoEstoque.Text = frm.retorno["DESCRICAO"].ToString();
                materiaVal = true;
            }
            else
            {
                txtIdEstoque.Text = "";
                txtDescricaoEstoque.Text = "";
                materiaVal = false;
            }
        }


        private void BtnBuscaProdutoNFe_Click(object sender, EventArgs e)
        {
            if (fornecedor)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT DISTINCT P.COD_PROD, P.DESC_PROD, F.id COD_FOR, F.NOME ");
                sql.Append("FROM NF_PROD P ");
                sql.Append("JOIN NF N ON(N.ID = P.NF) ");
                sql.Append("JOIN FORNECEDOR F ON(N.FORNECEDOR = F.ID) ");
                sql.Append("WHERE F.ID = " + txtIDFornecedor.Text);

                frmBusca frm = new frmBusca(sql, "Produtos");
                frm.ShowDialog();
                if (frm.retorno != null)
                {
                    txtIDProd.Text = frm.retorno["COD_PROD"].ToString();
                    txtProduto.Text = frm.retorno["DESC_PROD"].ToString();
                    produtoVal = true;
                }
                else
                {
                    txtIDProd.Text = "";
                    txtProduto.Text = "";
                    produtoVal = false;
                }
            }
            else
            {
                MessageBox.Show("Para adicionar um produto é necessário adicionar o fornecedor antes!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvLink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLink.Columns["colExcluir"].Index && dgvLink.Rows.Count > 0 && e.RowIndex > -1)
            {
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("Deseja excluir o link do \nFornecedor: " + dgvLink["colDescFor", e.RowIndex].Value.ToString());
                mensagem.Append("\nProduto: " + dgvLink["colDescProd", e.RowIndex].Value.ToString());
                mensagem.Append("\nEstoque: " + dgvLink["colDescEst", e.RowIndex].Value.ToString());
                DialogResult result = MessageBox.Show(mensagem.ToString(), "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    auxSQL.excluirLinkNFxProdXfor(int.Parse(dgvLink["colID", e.RowIndex].Value.ToString()));
                    preencherCampos();
                }

            }
        }

        private void BtnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, NOME, NOME_FANTASIA FROM FORNECEDOR ORDER BY NOME ");

            frmBusca frm = new frmBusca(sql, "Fornecedores");
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIDFornecedor.Text = frm.retorno["ID"].ToString();
                txtDescFornecedor.Text = frm.retorno["NOME"].ToString();
                fornecedor = true;
            }
            else
            {
                txtIDFornecedor.Text = "";
                txtDescFornecedor.Text = "";
                fornecedor = false;
            }
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT A.ID, A.COD_PROD_NF COD_PROD, P.DESC_PROD DESC_PROD, ");
            sql.Append("C.ID COD_EST, C.DESCRICAO DESC_EST, ");
            sql.Append("F.ID COD_FOR, F.NOME DESC_FOR, A.QT_CAIXA ");
            sql.Append("FROM NFPROD_CONTROLESTQ A ");
            sql.Append("JOIN FORNECEDOR F ON(A.FOR_ID = F.id) ");
            sql.Append("JOIN NF_PROD P ON(P.COD_PROD = A.COD_PROD_NF) ");
            sql.Append("JOIN CONTROLE_ESTOQUE C ON(C.ID = A.COD_CONTRESTQ) ");
            sql.Append("ORDER BY DESC_EST ");
            dgvLink.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }
    }
}
