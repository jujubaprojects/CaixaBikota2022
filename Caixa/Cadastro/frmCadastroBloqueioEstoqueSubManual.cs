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
    public partial class frmCadastroBloqueioEstoqueSubManual : FormJCS
    {
        private int idEst, tipoEst;

        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        public frmCadastroBloqueioEstoqueSubManual()
        {
            InitializeComponent();
            preencherCampos();

            cboFiltro.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID AS ID_ESTOQUE, DESCRICAO, TIPO_ESTOQUE AS TIPO_EST ");
            sql.Append("FROM ( ");
            sql.Append("SELECT EP.ID,  CONCAT(P.DESCRICAO, ' - ', DBO.RETORNA_SABORES(EP.ID)) AS DESCRICAO, 1 TIPO_ESTOQUE ");
            sql.Append("FROM ESTOQUE_POTE EP  ");
            sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID)  ");
            sql.Append("JOIN BLOQUEIO_EST_SUB BE ON (BE.ID_ESTOQUE = EP.ID) ");
            sql.Append("WHERE BE.TIPO_EST = 1 ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT CE.ID, CE.DESCRICAO, 2 TIPO_ESTOQUE ");
            sql.Append("FROM CONTROLE_ESTOQUE CE ");
            sql.Append("JOIN BLOQUEIO_EST_SUB BE ON (BE.ID_ESTOQUE = CE.ID) ");
            sql.Append("        WHERE BE.TIPO_EST = 2 ");
            sql.Append("	) A ");
            if (cboFiltro.SelectedIndex == 1)
                sql.Append("WHERE A.TIPO_ESTOQUE = 1 ");
            if (cboFiltro.SelectedIndex == 2)
                sql.Append("WHERE A.TIPO_ESTOQUE = 2 ");


            DataTable dt = auxSQL.retornaDataTable(sql.ToString());
            dgvBloqueioEstoque.DataSource = dt;
        }

        private void CboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDEstoque.Text = "";
            txtDescEstoque.Text = "";
            tipoEst = cboTipo.SelectedIndex;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            if (cboTipo.SelectedIndex > 0)
            {
                if (cboTipo.SelectedIndex == 1)
                {
                    sql.Append("SELECT EP.ID, P.DESCRICAO PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE, DATA  ");
                    sql.Append("FROM ESTOQUE_POTE EP  ");
                    sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID)  ");
                    sql.Append("WHERE EP.ID NOT IN (SELECT ID_ESTOQUE FROM BLOQUEIO_EST_SUB WHERE TIPO_EST = 1) ");
                    sql.Append("ORDER BY 2,3  ");
                }
                else
                {
                    sql.Append("SELECT CE.ID, CE.DESCRICAO, CE.QT_ESTOQUE QT_RESTANTE ");
                    sql.Append("FROM CONTROLE_ESTOQUE CE ");
                    sql.Append("WHERE STATUS = 1  AND CE.ID NOT IN (SELECT ID_ESTOQUE FROM BLOQUEIO_EST_SUB WHERE TIPO_EST = 2)");
                    sql.Append("ORDER BY DESCRICAO ");
                }

                frmBusca frm = new frmBusca(sql, "Busca de Estoque");
                frm.ShowDialog();

                if (frm.retorno != null)
                {
                    idEst = int.Parse(frm.retorno["ID"].ToString());
                    txtIDEstoque.Text = idEst.ToString();
                    if (cboTipo.SelectedIndex == 1)
                        txtDescEstoque.Text = frm.retorno["PRODUTO"].ToString() + " - " + frm.retorno["DESCRICAO"].ToString();
                    else
                        txtDescEstoque.Text = frm.retorno["DESCRICAO"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtIDEstoque.Text))
                return false;

            idEst = int.Parse(txtIDEstoque.Text);

            return true;
        }

        private void DgvBloqueioEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvBloqueioEstoque.Columns["colApagar"].Index && dgvBloqueioEstoque.Rows.Count > 0 && e.RowIndex != dgvBloqueioEstoque.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Deseja remover o bloqueio manual para o estoque: " + dgvBloqueioEstoque["colDescricao", e.RowIndex].Value.ToString() + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.retornaDataTable("DELETE FROM BLOQUEIO_EST_SUB WHERE ID_ESTOQUE = " + dgvBloqueioEstoque["colIDEstoque", e.RowIndex].Value  + " AND TIPO_EST = " + dgvBloqueioEstoque["colTipoEst", e.RowIndex].Value);
                        preencherCampos();
                    }


                }
            }
        }

        private void CboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void BtnSalvarEstoque_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            { 
            DialogResult result = MessageBox.Show("Deseja salvar o bloqueio manual para o estoque: " + txtDescEstoque.Text + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertBloqueioSubEst(idEst, tipoEst);
                        preencherCampos();
                    }


                }
            }


        }



}
}
