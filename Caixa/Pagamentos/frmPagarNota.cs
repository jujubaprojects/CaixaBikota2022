using Componentes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    public partial class frmPagarNota : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private int tipoPagamento = 0;
        private dal.Conexao conexao = new dal.Conexao();
        //private SqlConnection conn;
        //private NpgsqlTransaction transacao;
        //private bool salvar = false;
        private DataTable dtGrid = new DataTable();
        private DataTable dtProduto = new DataTable();
        //private int qtSalva = 0;
        private bool controleEsc = true;

        public frmPagarNota()
        {
            InitializeComponent();

            cboTipoPagamento.SelectedIndex = 0;

            //conn = conexao.retornaConexao();
            //transacao = conexao.startTransaction(conn);

            txtProduto.Text = "PAGAMENTO NOTA";
        }


        //private void BtnAdddProduto_Click(object sender, EventArgs e)
        //{
                //conn = conexao.retornaConexao();
                /*transacao = conexao.startTransaction(conn);

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, TIPO, DT_ALTERACAO) VALUES (");
                sql.Append("@pedidoID, ");
                sql.Append("(SELECT ID FROM PRODUTO WHERE UPPER(DESCRICAO) = UPPER(@produto)), ");
                sql.Append("@qt, @descricao, @situacao, ");
                sql.Append("(SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @tipo), DATE_TRUNC('second', now()))");

                SqlCommand sqlc = new SqlCommand(sql.ToString(), conn);

                sqlc.CommandType = CommandType.Text;
                sqlc.Parameters.AddWithValue("@pedidoID", 35);
                sqlc.Parameters.AddWithValue("@produto", cboProdutoFilho.SelectedItem.ToString());
                sqlc.Parameters.AddWithValue("@qt", int.Parse(txtQuantidade.Text));
                sqlc.Parameters.AddWithValue("@descricao", "PAGAMENTO RÁPIDO");
                sqlc.Parameters.AddWithValue("@tipo", "CONSUMIR");
                sqlc.Parameters.AddWithValue("@situacao", 3);

                auxSQL.executaQueryTransaction(conn, sqlc);

                DataTable dt = new DataTable();
                sqlc = new SqlCommand("SELECT * FROM PEDIDO_PRODUTO WHERE PEDIDO = 35", conn);
                NpgsqlDataReader Adpt = sqlc.ExecuteReader();
                dt.Load(Adpt);*/

        //}

        private void CboTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPagamento = cboTipoPagamento.SelectedIndex + 1;
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtDescNota.Text) || txtDescNota.Text.ToUpper().Equals("NOME PESSOA"))
            {
                MessageBox.Show("Informe o nome da pessoa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescNota.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtVlNota.Text.Trim()) || double.Parse(txtVlNota.Text) <= 0)
            {
                MessageBox.Show("Informe o valor da nota!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVlNota.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtVlRecebido.Text.Trim()) || double.Parse(txtVlRecebido.Text) <= 0)
            {
                MessageBox.Show("Informe o valor recebido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVlRecebido.Focus();
                return false;
            }

            return true;
        }

        private void BtnFinalizarPagamento_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                auxSQL.insertPedido("PAGAMENTO DE NOTA", "CONSUMIR", 4);

                int pedidoID = int.Parse(auxSQL.buscaUltimoPedido("PAGAMENTO DE NOTA").Rows[0][0].ToString());

                auxSQL.insertPedidoProduto(pedidoID, txtProduto.Text, 1, "PAGAMENTO DE NOTA", 3);

                int pedidoProdutoID = int.Parse(auxSQL.retornaDataTable("SELECT MAX(ID) FROM PEDIDO_PRODUTO WHERE PEDIDO = " + pedidoID).Rows[0][0].ToString());

                if (double.Parse(txtVlRecebido.Text) > double.Parse(txtVlNota.Text))
                    auxSQL.insertPagamentoPedidoID(pedidoProdutoID, double.Parse(txtVlNota.Text), tipoPagamento);
                else
                    auxSQL.insertPagamentoPedidoID(pedidoProdutoID, double.Parse(txtVlRecebido.Text), tipoPagamento);

                this.Close();
            }
        }

        private void TxtVlRecebido_TextChanged(object sender, EventArgs e)
        {
            if (tipoPagamento == 1 && !string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                double aux = double.Parse(txtVlRecebido.Text) - double.Parse(txtVlNota.Text);
                if (aux >= 0)
                    lblTroco.Text = "Troco R$ " + aux.ToString("0.00");
            }
        }

        private void FrmPedidoRapido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmPedidoRapido_MouseMove(object sender, MouseEventArgs e)
        {
            controleEsc = false;
            this.MouseMove -= FrmPedidoRapido_MouseMove;
        }

        private void TxtDescNota_Click(object sender, EventArgs e)
        {
            if (txtDescNota.Text == "Nome Pessoa")
                txtDescNota.Text = "";
        }
    }
}
