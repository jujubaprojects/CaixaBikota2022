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

namespace Caixa.Caixa
{
    public partial class frmFluxoCaixa : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void btnAddManual_Click(object sender, EventArgs e)
        {

        }

        private void preencherGrid ()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT C.ID ID_COLABORADOR, C.NOME, LF.DATA_FOLGA DATA ");
            sql.Append("FROM COLABORADOR C ");
            sql.Append("JOIN LEMBRETE_FOLGA LF ON(C.ID = LF.ID_FUNCIONARIO) ");
            sql.Append("WHERE 1 = 1 ");

            //DataTable dt = auxSQL.retornaDataTable("");
            if (cboFiltroPagamento.SelectedIndex > 0)
                sql.Append("AND C.NOME LIKE '" + cboFiltroPagamento.SelectedItem + "' ");


            sql.Append("ORDER BY DATA DESC, NOME ASC ");
            dgvFluxoCaixa.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }
    }
}
