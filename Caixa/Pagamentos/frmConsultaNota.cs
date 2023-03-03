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

namespace Caixa.Pagamentos
{
    public partial class frmConsultaNota :  FormJCS
    {
        private SQL.SQL sqlAux = new SQL.SQL();
        public frmConsultaNota()
        {
            InitializeComponent();

            buscaClientes();
        }

        private void buscaClientes()
        {
            string sql = "SELECT ID, NOME, VALOR FROM CLIENTE ORDER BY NOME ";
            dgvNotas.DataSource = sqlAux.retornaDataTable(sql);
        }
    }
}
