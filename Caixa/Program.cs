using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPagamentos(9, "LB2"));
            //Application.Run(new frmPedidos());
            //Application.Run(new frmNovoPedido(2, 30));
            
            Application.Run(new frmMenu()); 
            
        }
    }
}

