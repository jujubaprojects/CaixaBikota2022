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
        private int tipo = 1;
        public frmConsultaEstoquePotes()
        {
            InitializeComponent();

            preencherCombo(auxSQL.retornaDataTable("SELECT * FROM PRODUTO WHERE TIPO = 4"), cboFiltroProduto);
            preencherCampos();
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            if (rbtEstoquePote.Checked)
            {
                sql.Append("SELECT EP.ID ID_ESTOQUE, P.DESCRICAO PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE, DATA, 'Ver Hist.' HISTORICO  ");
                sql.Append("FROM ESTOQUE_POTE EP ");
                sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
                sql.Append("WHERE 1 = 1 ");
                if (cboFiltroProduto.SelectedIndex > 0)
                    sql.Append("AND  P.DESCRICAO = '" + cboFiltroProduto.SelectedItem.ToString() + "' ");
                if (!string.IsNullOrEmpty(txtDescricao.Text))
                    sql.Append("AND  dbo.RETORNA_SABORES(EP.ID) LIKE '%" + txtDescricao.Text.Replace(" ", "%") + "%' ");
                if (!string.IsNullOrEmpty(txtFiltroQT.Text))
                    sql.Append("AND EP.QT_EST = " + txtFiltroQT.Text + " ");
                sql.Append("ORDER BY 2, QT_RESTANTE DESC");
            }
            else
            {
                sql.Append("SELECT DISTINCT ce.ID ID_ESTOQUE, CE.DESCRICAO PRODUTO, '' DESCRICAO, CE.QT_ESTOQUE QT_RESTANTE, '' DATA, 'Ver Hist.' HISTORICO ");
                sql.Append("FROM CONTROLE_ESTOQUE CE ");
                sql.Append("WHERE 1 = 1 ");
                if (!string.IsNullOrEmpty(txtDescricao.Text))
                    sql.Append("AND  CE.DESCRICAO LIKE '%" + txtDescricao.Text.Replace(" ", "%") + "%' ");
                if (!string.IsNullOrEmpty(txtFiltroQT.Text))
                    sql.Append("AND CE.QT_ESTOQUE = " + txtFiltroQT.Text + " ");
            }

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

        private void DgvLink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLink.Columns["colHistorico"].Index && dgvLink.Rows.Count > 0)
            {
                //DialogResult result = MessageBox.Show("Deseja alterar as informações do Cliente ' + " + dgvClientes["colNome", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                //    //id = int.Parse(dgvClientes["colID", e.RowIndex].Value.ToString());
                //    //tipoOperacao = 1;
                //    //txtNome.Text = dgvClientes["colNome", e.RowIndex].Value.ToString();
                //    //txtContato.Text = dgvClientes["colContato", e.RowIndex].Value.ToString();
                //    //txtEnd.Text = dgvClientes["colEnd", e.RowIndex].Value.ToString();
                //    //cboStatus.SelectedIndex = bool.Parse(dgvClientes["colStatus", e.RowIndex].Value.ToString()) ? 1 : 0;

                //    //btnSalvar.Text = "Alterar Cadastro";

                //}
                frmBusca frm = new frmBusca(queryInfEstoque(int.Parse(dgvLink["colIDEstoque", e.RowIndex].Value.ToString()),tipo), "Historico " + dgvLink["colDescricao", e.RowIndex].Value.ToString());
                frm.ShowDialog();
            }
        }

        private StringBuilder queryInfEstoque (int pID, int pTipo) //tipo 1 = baldes; 2  = materia prima;
        {

            StringBuilder sql = new StringBuilder();
            if (pTipo == 1)
            {
                sql.Append("SELECT AUX.DESCRICAO, AUX.SABOR, AUX.ID, AUX.TIPO_EST, AUX.ID_ESTOQUE,  ");
                sql.Append("CASE WHEN QT_ESTOQUE_ATUAL >= QT_ANTERIOR THEN 'ADICIONOU' ");
                sql.Append("WHEN QT_ESTOQUE_ATUAL < QT_ANTERIOR THEN 'DIMINUIU' ");
                sql.Append("ELSE 'ERRO' END INFORMACAO, ");
                sql.Append("AUX.DATA ");
                sql.Append("FROM( ");
                sql.Append("SELECT P.DESCRICAO, DBO.RETORNA_SABORES(LRE.ID_ESTOQUE) AS SABOR, LRE.*, ");
                sql.Append("LAG(LRE.QT_ESTOQUE_ATUAL, 1, 0) OVER(ORDER BY LRE.ID_ESTOQUE, LRE.DATA ASC) QT_ANTERIOR ");
                sql.Append("FROM LOG_REGISTROS_ESTOQUE LRE ");
                sql.Append("JOIN ESTOQUE_POTE EP ON(EP.ID = LRE.ID_ESTOQUE) ");
                sql.Append("JOIN PRODUTO P ON(P.ID = EP.PRODUTO) ");
                sql.Append("WHERE LRE.TIPO_EST = 1 ");
                if (pID > 0)
                    sql.Append("AND LRE.ID_ESTOQUE = " + pID);
                sql.Append(") ");
                sql.Append("AUX ");
                sql.Append("ORDER BY DATA DESC ");
            }
            else
            {

                sql.Append("SELECT AUX.DESCRICAO, AUX.SABOR, AUX.ID, AUX.TIPO_EST, AUX.ID_ESTOQUE,   ");
                sql.Append("CASE WHEN QT_ESTOQUE_ATUAL >= QT_ANTERIOR THEN 'ADICIONOU' WHEN QT_ESTOQUE_ATUAL<QT_ANTERIOR THEN 'DIMINUIU' ELSE 'ERRO' END INFORMACAO, AUX.DATA ");
                sql.Append("FROM( ");
                sql.Append("SELECT CE.DESCRICAO, '' AS SABOR, LRE.*, ");
                sql.Append("LAG(LRE.QT_ESTOQUE_ATUAL, 1, 0) OVER(ORDER BY LRE.ID_ESTOQUE, LRE.DATA ASC) QT_ANTERIOR ");
                sql.Append("FROM LOG_REGISTROS_ESTOQUE LRE ");
                sql.Append("JOIN CONTROLE_ESTOQUE CE ON(CE.ID = LRE.ID_ESTOQUE) ");
                sql.Append("WHERE LRE.TIPO_EST = 2 ");
                if (pID > 0)
                    sql.Append("AND LRE.ID_ESTOQUE = " + pID);
                sql.Append(") AUX          ");
                sql.Append("ORDER BY DATA DESC ");
            }



            return sql;
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            frmBusca frm = new frmBusca(queryInfEstoque(0,tipo), "Histórico Completo");
            frm.ShowDialog();
        }

        private void RbtEstoquePote_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            preencherCampos();
            lblDescricao.Text = "Sabor:";
            cboFiltroProduto.Enabled = true;
        }

        private void RbtEstMatPrima_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            preencherCampos();
            lblDescricao.Text = "Desc.:";
            cboFiltroProduto.Enabled = false;
        }
    }
}
