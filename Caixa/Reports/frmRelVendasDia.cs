using Caixa.Estoque;
using Componentes;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Componentes.MaskedTextBoxJCS;

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

            frmConsultaBaldesVendidosXRegistrados frmC = new frmConsultaBaldesVendidosXRegistrados(dtpDataInicial.Value.ToString("yyyy-MM-dd"));
            frmC.ShowDialog();

            DataTable dt = auxSQL.relVendasDia(dtpDataInicial.Value.ToShortDateString());
            string[] arrayParametros = new string[] { "Data", dtpDataInicial.Value.ToString("yyyy-MM-dd") }; 
            frmRelatorio frm = new frmRelatorio(dt, "relVendasDia.rdlc", "dsRel", "frmRelVendasDia", arrayParametros);
            frm.ShowDialog();
        }

        private void buscaBaldes()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ISNULL(PG.DT_PAGAMENTO, PP.DT_ALTERACAO) DATA, CONCAT('TIPO VENDIDO: ', PED.DESCRICAO) TIPO, CONCAT('', PP.QT_PRODUTO) BALDE_QT, PP.DESCRICAO, PP.SITUACAO ");
sql.Append("FROM PEDIDO_PRODUTO PP ");
sql.Append("JOIN PEDIDO PED ON(PED.ID = PP.PEDIDO) ");
sql.Append("RIGHT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
sql.Append("WHERE PP.PRODUTO = 44 AND(convert(varchar, PG.DT_PAGAMENTO, 103) = '" + dtpDataInicial.Value.ToString("dd/MM/yyyy") + "' OR convert(varchar, PP.DT_ALTERACAO, 103) = '" + dtpDataInicial.Value.ToString("dd/MM/yyyy") + "') ");
sql.Append("UNION ALL ");
sql.Append("SELECT DATA, CONCAT('TIPO ANOTADO: ', NOME) , BALDE, NULL, NULL ");
sql.Append("FROM BALDES ");
sql.Append("WHERE convert(varchar, DATA, 103) = '" + dtpDataInicial.Value.ToString("dd/MM/yyyy") + "' ");
sql.Append("ORDER BY DATA ");

            frmBusca frm = new frmBusca(sql, "Baldes Anotados x Vendidos");
            frm.ShowDialog();
        }

        private void btnVerificarBaldes_Click(object sender, EventArgs e)
        {
            buscaBaldes();
        }
    }
}
