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

namespace Caixa.Estoque
{
    public partial class frmLinkEstoqueProduto : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private bool produtoVal = false, materiaVal = false, fornecedor = false;
        public frmLinkEstoqueProduto()
        {
            InitializeComponent();

            preencherCampos();
        }

        private void BtnBuscaProduto_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM PRODUTO");

            frmBusca frm = new frmBusca(sql, "Produtos");            
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIDProd.Text = frm.retorno["ID"].ToString();
                txtProduto.Text = frm.retorno["DESCRICAO"].ToString();
                produtoVal = true;
            }
            else
            {
                txtIDProd.Text = "";
                txtProduto.Text = "";
                produtoVal = false;
            }
        }

        private void BtnBuscaMateriaPrima_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, PRODUTO, DESCRICAO, UNIDADE_MEDIDA FROM CONTROLE_ESTOQUE order by PRODUTO");

            frmBusca frm = new frmBusca(sql, "Materia Prima");
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIdEstoque.Text = frm.retorno["ID"].ToString();
                txtDescricaoEstoque.Text = frm.retorno["PRODUTO"].ToString() ;
                materiaVal = true;
            }
            else
            {
                txtIdEstoque.Text = "";
                txtDescricaoEstoque.Text = "";
                materiaVal = false;
            }
        }

        private void BtnLinkar_Click(object sender, EventArgs e)
        {
            if (materiaVal && produtoVal && fornecedor)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM SUB_ESTOQUE ");
                sql.Append("WHERE PRODUTO = " + int.Parse(txtIDProd.Text));
                sql.Append(" and CONTROLE_ESTOQUE = " + int.Parse(txtIdEstoque.Text));
                sql.Append(" and CONTROLE_ESTOQUE = " + int.Parse(txtIdEstoque.Text));
                DataTable dt = auxSQL.retornaDataTable("select * from SUB_ESTOQUE where produto = " + int.Parse(txtIDProd.Text) + "  and CONTROLE_ESTOQUE = " + int.Parse(txtIdEstoque.Text));

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Este link já foi cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if ()
                auxSQL.insertLinkProdutoxMateriaPrima(int.Parse(txtIDProd.Text), int.Parse(txtIdEstoque.Text), int.Parse(txtQtSub.Text));
                MessageBox.Show("Link criado na base de dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preencherCampos();
                limparCampos();
            }
            else
                MessageBox.Show("Por favor, preencha os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparCampos()
        {
            this.limpar(txtProduto);
            this.limpar(txtDescricaoEstoque);
            this.limpar(txtIdEstoque);
            this.limpar(txtIDProd);
        }

        private void BtnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM FORNECEDOR ORDER BY NOME ");

            frmBusca frm = new frmBusca(sql, "Fornecedores");
            frm.ShowDialog();
            if (frm.retorno != null)
            {
                txtIDFornecedor.Text = frm.retorno["ID"].ToString();
                txtDescFornecedor.Text = frm.retorno["PRODUTO"].ToString();
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
            sql.Append("SELECT SE.ID, P.DESCRICAO AS PRODUTO, CONCAT(CE.PRODUTO, ' - ', CE.DESCRICAO) AS MATERIA_PRIMA, QT_SUB ");
            sql.Append("FROM PRODUTO P ");
            sql.Append("JOIN SUB_ESTOQUE SE ON(P.ID = SE.PRODUTO) ");
            sql.Append("JOIN CONTROLE_ESTOQUE CE ON(CE.ID = SE.CONTROLE_ESTOQUE) ORDER BY PRODUTO ");
            dgvLink.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }
    }
}
