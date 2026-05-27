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
    public partial class frmConsultaBaldesVendidosXRegistrados : FormJCS
    {
        SQL.SQL auxSQL = new SQL.SQL();
        public frmConsultaBaldesVendidosXRegistrados(string pData)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(pData))
                preencherCampos();
            else
                dtpData.Value = DateTime.Parse(pData);
        }

        private void preencherCampos(string pParametro = null)
        {
            string pData = "'" + dtpData.Value.ToString("yyyy-MM-dd") + "'";
            if (pParametro != null)
                pData = "'"+pParametro+"'";
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT PED.ID ID_PEDIDO, PED.DESCRICAO DESC_PEDIDO, PP.ID ID_PEDIDO_PRODUTO, PP.DT_ALTERACAO, ");
            sql.Append("PP.QT_PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.SITUACAO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("WHERE PP.PRODUTO = 44 ");
            if (!chkTodos.Checked)
                sql.Append("AND CONVERT(VARCHAR, PP.DT_ALTERACAO, 103) = " + pData);
            else
                sql.Append("AND CONVERT(VARCHAR, PP.DT_ALTERACAO, 103) = " + pData);

            dgvVendidos.DataSource = auxSQL.retornaDataTable(sql.ToString());
            sql.Clear();



            sql.Append("SELECT PG.ID ID_PAGAMENTO, TP.DESCRICAO, PP.ID ID_PEDIDO_PRODUTO, PG.DT_PAGAMENTO DT_PAGAMENTO, ");
            sql.Append("PG.VL_PAGO, PP.DESCRICAO DESC_PRODUTO ");
            sql.Append("FROM PAGAMENTO PG ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("JOIN TIPO_PAGAMENTO TP ON(TP.ID = PG.TIPO_PAGAMENTO) ");
            sql.Append("WHERE PP.PRODUTO = 44 ");
            if (!chkTodos.Checked)
                sql.Append("AND CONVERT(VARCHAR, PG.DT_PAGAMENTO, 103) = " + pData);
            else
                sql.Append("AND CONVERT(VARCHAR, PP.DT_ALTERACAO, 103) = " + pData);
            dgvPagos.DataSource = auxSQL.retornaDataTable(sql.ToString());
            sql.Clear();


            sql.Append("SELECT B.ID ID_BALDE, B.NOME, B.BALDE,B.DATA,  B.TELEFONE, B.COLHER ");
            sql.Append("FROM BALDES B ");
            if (!chkTodos.Checked)
                sql.Append("WHERE CONVERT(VARCHAR, B.DATA, 103) = " + pData);
            else
                sql.Append("AND CONVERT(VARCHAR, PP.DT_ALTERACAO, 103) = " + pData);
            dgvMarcados.DataSource = auxSQL.retornaDataTable(sql.ToString());

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }
    }
}
