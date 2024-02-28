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
    public partial class frmConsultaEstoquePotes : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        public frmConsultaEstoquePotes()
        {
            InitializeComponent();

            preencherCombo(auxSQL.retornaDataTable("SELECT * FROM PRODUTO WHERE TIPO = 4"), cboFiltroProduto);
            preencherCampos();
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT P.DESCRICAO PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE, DATA  ");
            sql.Append("FROM ESTOQUE_POTE EP ");
            sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
            sql.Append("WHERE 1 = 1 ");
            if (cboFiltroProduto.SelectedIndex > 0)
                sql.Append("AND  P.DESCRICAO = '" + cboFiltroProduto.SelectedItem.ToString() + "' ");
        if (!string.IsNullOrEmpty(txtFiltroSabor.Text))
            sql.Append("AND  dbo.RETORNA_SABORES(EP.ID) LIKE '%" + txtFiltroSabor.Text.Replace(" ", "%") + "%' ");
        if (!string.IsNullOrEmpty(txtFiltroQT.Text))
            sql.Append("AND EP.QT_EST = " + txtFiltroQT.Text + " ");
            sql.Append("ORDER BY 1, QT_RESTANTE DESC");

            dgvLink.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }

        private void CboFiltroProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void TxtFiltroSabor_TextChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void TxtFiltroQT_TextChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void preencherCombo(DataTable pDTable, ComboBox pCombo)
        {

            pCombo.Items.Add("TODOS POTES");
            for (int i = 0; i < pDTable.Rows.Count; i++)
            {
                pCombo.Items.Add(pDTable.Rows[i]["descricao"]);
            }

        }
    }
}
