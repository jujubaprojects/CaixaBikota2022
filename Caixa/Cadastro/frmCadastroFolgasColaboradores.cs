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
    public partial class frmCadastroFolgasColaboradores : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        public frmCadastroFolgasColaboradores()
        {
            InitializeComponent();
            preencherGrid();
            preencherCombo();
        }

        private void preencherCombo()
        {
            DataTable dt = auxSQL.retornaDataTable("SELECT * FROM COLABORADOR ORDER BY NOME");
            for (int i = 0; i < dt.Rows.Count; i++)
                cboColaborador.Items.Add(dt.Rows[i]["NOME"].ToString());
        }

        private void CboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void CboColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherGrid();
            if (cboColaborador.SelectedIndex > 0)
                btnAddFolga.Enabled = true;
            else
                btnAddFolga.Enabled = false;
        }

        private void BtnAddFolga_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO LEMBRETE_FOLGA(ID_FUNCIONARIO, DATA_FOLGA) ");
            sql.Append("VALUES(SELECT ID, '" + dtpData.Value.ToString("yyyy-MM-dd") + "' FROM COLABORADOR WHERE NOME LIKE " + cboColaborador.SelectedItem + ") ");
            auxSQL.executaQuerySemRetorno(sql.ToString());
            preencherGrid();
        }

        private void BtnAddFolgasAutomatico_Click(object sender, EventArgs e)
        {
            auxSQL.executaQuerySemRetorno("EXEC PROC_INSERIR_FOLGAS_MENSAL");
            preencherGrid();
        }

        private void preencherGrid()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT C.ID ID_COLABORADOR, C.NOME, LF.DATA_FOLGA DATA ");
            sql.Append("FROM COLABORADOR C ");
            sql.Append("JOIN LEMBRETE_FOLGA LF ON(C.ID = LF.ID_FUNCIONARIO) ");
            sql.Append("WHERE 1 = 1 ");

            //DataTable dt = auxSQL.retornaDataTable("");
            if (cboColaborador.SelectedIndex > -1)
                sql.Append("AND C.NOME LIKE '" + cboColaborador.SelectedItem + "' ");
            if (cboMes.SelectedIndex > 0)
                sql.Append("AND MONTH(LF.DATA_FOLGA) = " + cboMes.SelectedIndex + 1 + " ");

            sql.Append("ORDER BY DATA DESC, NOME ASC ");
            dgvFolgas.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }

        private void DgvFolgas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvFolgas.Columns["colExcluir"].Index && dgvFolgas.Rows.Count > 0 && e.RowIndex != dgvFolgas.Rows.Count)
            {
                string aux = dgvFolgas["colNome", e.RowIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Deseja apgar a folga " + aux + " do dia " + dgvFolgas["colData", e.RowIndex].Value.ToString(), "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.executaQuerySemRetorno("DELETE FROM LEMBRETE_FOLGA WHERE DATA = '" + dgvFolgas["colData", e.RowIndex].Value.ToString() + "' AND ID_FUNCIONARIO = " + dgvFolgas["colColaboradorID", e.RowIndex].Value.ToString());
                        preencherGrid();
                    }
                }
            }
        }
    }
}
