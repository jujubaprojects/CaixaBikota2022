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

namespace Caixa.Estoque
{
    public partial class frmPedidoCompra : FormJCS

    { 
        private SQL.SQL sqlAux = new SQL.SQL();
    public frmPedidoCompra()
        {
            InitializeComponent();
            preencherCampos();
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, OBSERVACAO, 'COMPRAR' PEDIDO_COMPRA ");
            sql.Append("FROM CONTROLE_ESTOQUE ");
            sql.Append("WHERE QT_ESTOQUE = QT_ESTOQUE_IDEAL AND QT_ESTOQUE = 1 AND PEDIDO_COMPRA = 0");
            dgvPedidoCompra.DataSource = sqlAux.retornaDataTable(sql.ToString());
        }

        private void DgvPedidoCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPedidoCompra.Columns["colComprar"].Index && dgvPedidoCompra.Rows.Count > 0 && e.RowIndex > -1)
            {
                StringBuilder mensagem = new StringBuilder();
                DialogResult result = MessageBox.Show("Deseja adicionar o produto " + dgvPedidoCompra["colDescricao", e.RowIndex].Value.ToString() + " para a lista de compra? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sqlAux.retornaDataTable("UPDATE CONTROLE_ESTOQUE SET PEDIDO_COMPRA = 1 WHERE ID = " + dgvPedidoCompra["colID", e.RowIndex].Value.ToString());
                    preencherCampos();
                }

            }
        }
    }
}
