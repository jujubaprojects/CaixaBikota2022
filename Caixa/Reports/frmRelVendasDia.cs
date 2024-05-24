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
            //VALIDO A PARTIR DO DIA 10/05/24. COMO NÃO TEMOS OS VALORES ANTIGOS PARA INSERIR, NÃO É CONFIAVEL COLOCAR VALORES ANTIGOS.
            if (dtpDataInicial.Value.Date > Convert.ToDateTime("09/05/2024") && dtpDataInicial.Value.Date <= DateTime.Now.Date && auxSQL.retornaDataTable("SELECT ID, VALOR, DATA FROM CAIXA_DIARIO WHERE DATA = '" + dtpDataInicial.Value.ToString("yyyy-MM-dd") + "'").Rows.Count <= 0)
            {
                frmInputBoxJCS frmI = new frmInputBoxJCS("Informe o valor em dinheiro do " + dtpDataInicial.Value.ToString(), 2);
                frmI.ShowDialog();
                if (frmI.retorno != null)
                {
                    auxSQL.insertValorDiarioCaixa(Convert.ToDouble(frmI.retorno), dtpDataInicial.Value);
                }
            }


            DataTable dt = auxSQL.relVendasDia(dtpDataInicial.Value.ToShortDateString());
            string[] arrayParametros = new string[] { "Data", dtpDataInicial.Value.ToString("yyyy-MM-dd") }; 
            frmRelatorio frm = new frmRelatorio(dt, "relVendasDia.rdlc", "dsRel", "frmRelVendasDia", arrayParametros);
            frm.ShowDialog();
        }
    }
}
