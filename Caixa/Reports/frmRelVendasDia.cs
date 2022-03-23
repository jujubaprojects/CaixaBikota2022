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
    public partial class frmRelVendasDia : FormJCS
    {
        SQL.SQL auxSQL = new SQL.SQL();


        public frmRelVendasDia()
        {
            InitializeComponent();
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = auxSQL.relVendasDia(dtpDataInicial.Value.ToShortDateString());
            string[] arrayParametros = new string[] { "Data", dtpDataInicial.Value.ToString("yyyy-MM-dd") }; 
            frmRelatorio frm = new frmRelatorio(dt, "relVendasDia.rdlc", "dsRel", "frmRelVendasDia", arrayParametros);
            frm.ShowDialog();
        }
    }
}
