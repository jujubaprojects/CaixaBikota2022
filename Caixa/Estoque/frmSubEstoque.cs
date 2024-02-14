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
    public partial class frmSubEstoque : FormJCS
    {
        private int IDEstoque = 0, qtSubEst = 0, tipoEstAlt = 1, produtoID = 0;
        private SQL.SQL auxSQL = new SQL.SQL();


        public frmSubEstoque()
        {
            InitializeComponent();
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (tipoEstAlt == 1)
                {
                    auxSQL.updateSubEstoquePote(IDEstoque, qtSubEst);
                }
                else
                {
                    auxSQL.updateSubControleEstoque(IDEstoque, qtSubEst);
                }
            }
            else
                MessageBox.Show("As informações não estão corretas, por favor insira novamente as informações.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            StringBuilder sql = queryBuscaEstoque();
            frmBusca frm = new frmBusca(sql, "Busca de Estoque");
            frm.ShowDialog();

            if (frm.retorno != null)
            {
                txtEstoque.Text = frm.retorno["DESCRICAO"].ToString();
                IDEstoque = int.Parse(frm.retorno["ID"].ToString());
            }
        }

        private void RbtPotes_CheckedChanged(object sender, EventArgs e)
        {
            tipoEstAlt = 1;
            limparCampos();
        }

        private void RbtProdutos_CheckedChanged(object sender, EventArgs e)
        {
            tipoEstAlt = 2;
            limparCampos();
        }

        private void TxtQt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQt.Text))
                txtQt.Text = "0";
            else
                qtSubEst = int.Parse(txtQt.Text);
        }

        private void limparCampos()
        {
            txtEstoque.Text = "";
            txtQt.Text = "0";
        }

        private bool validaCampos ()
        {
            if (string.IsNullOrEmpty(txtEstoque.Text))
                return false;
            if (int.Parse(txtQt.Text) <= 0)
                return false;


            return true;
        }

        private StringBuilder queryBuscaEstoque()
        {
            StringBuilder sql = new StringBuilder();

            if (tipoEstAlt == 1)
            {
                sql.Append("SELECT EP.ID, P.DESCRICAO PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE, DATA  ");
                sql.Append("FROM ESTOQUE_POTE EP  ");
                sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID)  ");
                sql.Append("WHERE EP.QT_EST > 0  ");
                sql.Append("ORDER BY 2,3  ");
            }
            else
            {
                sql.Append("SELECT ID, DESCRICAO ");
                sql.Append("FROM CONTROLE_ESTOQUE ");
                sql.Append("WHERE QT_ESTOQUE > 0 AND STATUS = 1 ");
                sql.Append("ORDER BY DESCRICAO ");
            }

            return sql;
        }
    }
}
