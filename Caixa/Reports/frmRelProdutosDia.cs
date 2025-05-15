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

namespace Caixa.Reports
{
    public partial class frmRelProdutosDia : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        public frmRelProdutosDia()
        {
            InitializeComponent();

            dtpDataInicial.Value = DateTime.Today;
            dtpDataFinal.Value = DateTime.Now;

            cboCresDesc.SelectedIndex = 1;
        }

        private void ButtonJCS1_Click(object sender, EventArgs e)
        {
            //if (dtpDataInicial.Value.Date > Convert.ToDateTime("09/05/2024") && dtpDataInicial.Value.Date <= DateTime.Now.Date && auxSQL.retornaDataTable("SELECT ID, VALOR, DATA FROM CAIXA_DIARIO WHERE DATA = '" + dtpDataInicial.Value.ToString("yyyy-MM-dd") + "'").Rows.Count <= 0)
            //{
            //    frmInputBoxJCS frmI = new frmInputBoxJCS("Informe o valor em dinheiro do " + dtpDataInicial.Value.ToString(), 2);
            //    frmI.ShowDialog();
            //    if (frmI.retorno != null)
            //    {
            //        auxSQL.insertValorDiarioCaixa(Convert.ToDouble(frmI.retorno), dtpDataInicial.Value);
            //    }
            //}


            DataTable dt = auxSQL.retornaDataTable(criarQuery());
            //string[] arrayParametros = new string[] { "Data", dtpDataInicial.Value.ToString("yyyy-MM-dd") };
            //frmRelatorio frm = new frmRelatorio(dt, "relProdutosDias.rdlc", "dsRel", "frmRelProdutosDia", arrayParametros);
            frmRelatorio frm = new frmRelatorio(dt, "relProdutosDia.rdlc", "dsRel", "frmRelProdutosDia");
            frm.ShowDialog();
        }

        private string criarQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT PROD.DESCRICAO PRODUTO, C.DESCRICAO CATEGORIA, PROD.VALOR VALOR_PRODUTO, SUM(PP.QT_PRODUTO) QT_VENDIDA, SUM(PP.QT_PRODUTO) * PROD.VALOR VALOR_VENDIDO ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("JOIN PEDIDO P ON(P.ID = PP.PEDIDO) ");
            sql.Append("JOIN PRODUTO PROD ON(PROD.ID = PP.PRODUTO) ");
            sql.Append("JOIN CATEGORIA C ON(C.TIPO = PROD.TIPO) ");
            sql.Append("WHERE P.SITUACAO != 0 AND PP.SITUACAO != 0 ");
            //sql.Append("AND PP.DT_ALTERACAO BETWEEN '" + dtpDataInicial.Value.ToString("yyyyMMdd HHmmss") + "' AND '" + dtpDataFinal.Value.ToString("yyyyMMdd HHmmss") + "' ");
            sql.Append("AND PP.DT_ALTERACAO BETWEEN '" + dtpDataInicial.Value.ToString("yyyy-MM-ddTHH:mm:ss") + "' AND '" + dtpDataFinal.Value.ToString("yyyy-MM-ddTHH:mm:ss") + "' ");
            if (!string.IsNullOrEmpty(txtProduto.Text))
                sql.Append("AND PROD.DESCRICAO LIKE %" + txtProduto.Text + "% ");
            if (!string.IsNullOrEmpty(txtCategoria.Text))
                sql.Append("AND C.DESCRICAO LIKE %" + txtCategoria.Text + "% ");
            sql.Append("GROUP BY PROD.DESCRICAO, C.DESCRICAO, PROD.VALOR ");
            if (rbtOrderQtProd.Checked)
                sql.Append("ORDER BY QT_VENDIDA ");
            if (rbtOrderProduto.Checked)
                sql.Append("ORDER BY PRODUTO ");
            if (rbtOrderCategoria.Checked)
                sql.Append("ORDER BY CATEGORIA ");
            if (cboCresDesc.SelectedIndex == 0)
                sql.Append("ASC ");
            else
                sql.Append("DESC ");



            return sql.ToString();
        }
    }
}
