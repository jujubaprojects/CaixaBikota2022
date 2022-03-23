using Componentes;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa.Reports
{
    public partial class frmRelatorio : FormJCS
    {
        SQL.SQL auxSQL = new SQL.SQL();
        private DataTable dtRelatorio;
        private string relName, dsName;
        private string[] parametros;


        public frmRelatorio(DataTable pDT, string pRelNome, string pDataSetName, string pFrmName, string [] pParametros = null)
        {
            dtRelatorio = pDT;
            relName = pRelNome;
            dsName = pDataSetName;
            this.Text = pFrmName;
            parametros = pParametros;

            InitializeComponent();
        }

        private void FrmRelVendas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.Reset();

            string caminho = Directory.GetCurrentDirectory();
            caminho = caminho.Remove(caminho.LastIndexOf("\\"));
            caminho = caminho.Remove(caminho.LastIndexOf("\\"));
            this.reportViewer1.LocalReport.ReportPath = caminho + "\\Reports\\" + relName ;

            ReportDataSource reportDataSource = new ReportDataSource();

            reportDataSource.Name = dsName;
            reportDataSource.Value = dtRelatorio;

            if (parametros != null)
            {
                for (int i = 0; i < parametros.Length; i+=2)
                {
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter(parametros[i], parametros[i+1]));
                    this.reportViewer1.RefreshReport();
                }
            }

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
