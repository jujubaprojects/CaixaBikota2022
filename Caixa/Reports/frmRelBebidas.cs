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
    public partial class frmRelBebidas : FormJCS
    {
        SQL.SQL auxSQL = new SQL.SQL();
        public frmRelBebidas()
        {
            InitializeComponent();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt = auxSQL.relVendasBebidas(dtpDataInicial.Value.ToShortDateString());
            string[] arrayParametros = new string[] { "Data", dtpDataInicial.Value.ToString("yyyy-MM-dd") };
            frmRelatorio frm = new frmRelatorio(dt, "relBebidas.rdlc", "dsRel", "frmRelBebidas", arrayParametros);
            frm.ShowDialog();
        }
    }
}
