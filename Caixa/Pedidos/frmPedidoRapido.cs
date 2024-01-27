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
    public partial class frmPedidoRapido : FormJCS
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
        private List<string> listSubPotes;

        public frmPedidoRapido()
        {
            InitializeComponent();

            preencherCombo(auxSQL.buscaProdutoPai(), cboProdutoPai);
            cboProdutoPai.SelectedIndex = 0;

            cboTipoPagamento.SelectedIndex = 0;

            //conn = conexao.retornaConexao();
            //transacao = conexao.startTransaction(conn);

            preencherColunasDt();
        }

        private void preencherColunasDt()
        {
            for (int i = 0; i < dgvProdutos.Columns.Count; i ++)
            {
                if (!string.IsNullOrEmpty(dgvProdutos.Columns[i].DataPropertyName))
                    dtGrid.Columns.Add(dgvProdutos.Columns[i].DataPropertyName);
            }
        }
        private void preencherDgv(DataTable dt)
        {
            dgvProdutos.DataSource = dt;
        }

        private void preencherCombo(DataTable pDTable, ComboBox pCombo)
        {
            pCombo.Items.Clear();
            for (int i = 0; i < pDTable.Rows.Count; i++)
            {
                pCombo.Items.Add(pDTable.Rows[i]["descricao"]);
            }
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvProdutos.Columns["colExcluir"].Index && dgvProdutos.Rows.Count > 0 && e.RowIndex != dgvProdutos.Rows.Count)
            {
                txtVlTotal.Text = (double.Parse(txtVlTotal.Text) - double.Parse(dtGrid.Rows[e.RowIndex]["VL_TOTAL"].ToString())).ToString("0.00");
                dtGrid.Rows[e.RowIndex].Delete();
                preencherDgv(dtGrid);
            }

        }

        private void BtnAdddProduto_Click(object sender, EventArgs e)
        {
            if (validaCamposNovoProd())
            {
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


                DataRow[] linhaProd = dtProduto.Select("DESCRICAO = '" + cboProdutoFilho.SelectedItem.ToString() + "'");
                int produtoID = int.Parse(linhaProd[0]["ID"].ToString());
                double vlProd = double.Parse(linhaProd[0]["VALOR"].ToString());

                DataRow row;

                row = dtGrid.NewRow();
                row["ID"] = produtoID;
                row["PRODUTO"] = cboProdutoFilho.SelectedItem.ToString();
                row["QT"] = txtQuantidade.Text;
                row["VL_PRODUTO"] = vlProd.ToString("0.00");
                //row["VL_TOTAL"] = (int.Parse(txtQuantidade.Text) * vlProd).ToString("0.00");
                row["VL_TOTAL"] = (double.Parse(txtQuantidade.Text) * vlProd).ToString("0.00");
                row["TIPO"] = cboProdutoPai.SelectedItem.ToString();

                txtVlTotal.Text = (double.Parse(txtVlTotal.Text) + double.Parse(row["VL_TOTAL"].ToString())).ToString("0.00");

                dtGrid.Rows.Add(row);

                preencherDgv(dtGrid);
            }
        }

        private bool validaCamposNota()
        {
            if (tipoPagamento == 5 )
            {
                if (cboAnotar.SelectedIndex < 0)
                {
                    MessageBox.Show("Informe a descrição da nota, ao lado do Tipo de Pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (auxSQL.buscaClienteInativo(cboAnotar.SelectedItem.ToString()).Rows.Count > 0)
                {
                    MessageBox.Show("Cliente inativo, por favor fale com o responsável!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (tipoPagamento == 1 && string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                MessageBox.Show("Informe o valor recebido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (double.Parse(txtVlRecebido.Text) < double.Parse(txtVlTotal.Text))
                {
                    MessageBox.Show("Valor recebido menor que o valor total!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (tipoPagamento == 9)
            {
                if (acessoFrmsRestrito())
                    return true;
                else
                    return false;
            }

            return true;
        }

        private bool acessoFrmsRestrito()
        {
            frmInputBoxJCS frm = new frmInputBoxJCS("Informe a senha.", 3, true);
            frm.ShowDialog();
            if (frm.retorno != "acessobikota")
            {
                MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool validaCamposNovoProd()
        {
            //if (string.IsNullOrEmpty(txtQuantidade.Text) || int.Parse(txtQuantidade.Text) == 0)
            if (string.IsNullOrEmpty(txtQuantidade.Text) || double.Parse(txtQuantidade.Text) == 0)
                {
                MessageBox.Show("Informe a quantidade do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void CboProdutoPai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProduto = auxSQL.buscaProdutoFilho(cboProdutoPai.SelectedItem.ToString());
            preencherCombo(dtProduto, cboProdutoFilho);
            cboProdutoFilho.SelectedIndex = 0;
        }

        private void CboTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aux = cboTipoPagamento.SelectedItem.ToString();
            if (aux.Equals("ANOTAR"))
                aux = "NOTA";

            tipoPagamento = int.Parse(auxSQL.retornaDataTable("SELECT ID FROM TIPO_PAGAMENTO WHERE DESCRICAO LIKE '" + aux + "'").Rows[0][0].ToString());
            
            switch (tipoPagamento)
            {
                case 1:
                    lblTroco.Visible = true;
                    cboAnotar.Visible = false;
                    txtVlRecebido.Enabled = true;
                    cboAnotar.Items.Clear();
                    break;

                case 5:
                    cboAnotar.Items.Clear();
                    lblTroco.Visible = false;
                    cboAnotar.Visible = true;
                    txtVlRecebido.Enabled = false;
                    txtVlRecebido.Text = txtVlTotal.Text;

                    DataTable dt = auxSQL.buscaClienteID(0,1);
                    for (int i = 0; i < dt.Rows.Count; i++)
                        cboAnotar.Items.Add(dt.Rows[i]["NOME"].ToString());
                    break;

                default:
                    cboAnotar.Items.Clear();
                    lblTroco.Visible = false;
                    cboAnotar.Visible = false;
                    txtVlRecebido.Enabled = false;
                    txtVlRecebido.Text = txtVlTotal.Text;
                    break;
            }
        }

        private void BtnFinalizarPagamento_Click(object sender, EventArgs e)
        {
            if (dtGrid.Rows.Count > 0)
            {
                if (validaCamposNota())
                {
                    listSubPotes = new List<string>();
                    for (int i = 0; i < dtGrid.Rows.Count; i++)
                    {
                        if (dtGrid.Rows[i]["TIPO"].ToString().Equals("POTES"))
                            listSubPotes.Add(dtGrid.Rows[i]["PRODUTO"].ToString());
                    }
                    if (listSubPotes.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("O pote de sorvete é dos prontos?\nSe sim, escolha o sabor na tela seguinte!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (result == DialogResult.Yes)
                            {
                                for (int i = 0; i < listSubPotes.Count; i++)
                                {
                                    StringBuilder sql = new StringBuilder();
                                    sql.Append("SELECT EP.ID, EP.PRODUTO, DBO.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT_RESTANTE  ");
                                    sql.Append("FROM ESTOQUE_POTE EP ");
                                    sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
                                    sql.Append("WHERE P.DESCRICAO = '" + listSubPotes[i] + "' ");
                                    sql.Append("ORDER BY DESCRICAO");

                                    int aux = 0;
                                    while (true)
                                    {
                                        aux++;
                                        frmBusca frm = new frmBusca(sql, "Estoque dos Sabores de " + listSubPotes[i]);
                                        frm.ShowDialog();
                                        if (frm.retorno != null)
                                        {
                                            auxSQL.updateAddEstoquePote(int.Parse(frm.retorno["ID"].ToString()), -1);
                                            break;
                                        }
                                        else
                                        {
                                            if (aux > 1)
                                                break;

                                            MessageBox.Show("É obrigatório escolher o pote de sorvete!\n\nCaso você tenha clicado em sim incorretamente, saia desta tela mais uma vez sem clicar em nenhum campo para voltar a tela anterior!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }

                                    if (aux > 1)
                                        return;
                                }


                            }
                        }
                    }

                    auxSQL.insertPedido("PAGAMENTO RÁPIDO", "LEVAR", 4);
                    int pedidoID = int.Parse(auxSQL.buscaUltimoPedido("PAGAMENTO RÁPIDO").Rows[0][0].ToString());
                    int pedidoProdutoID = 0;
                    for (int i = 0; i < dtGrid.Rows.Count; i++)
                    {
                        //auxSQL.insertPedidoProduto(pedidoID, dtGrid.Rows[i]["PRODUTO"].ToString(), int.Parse(dtGrid.Rows[i]["QT"].ToString()), "PAGAMENTO RÁPIDO","", 3);
                        auxSQL.insertPedidoProduto(pedidoID, dtGrid.Rows[i]["PRODUTO"].ToString(), double.Parse(dtGrid.Rows[i]["QT"].ToString()), "PAGAMENTO RÁPIDO", "", 3);
                        pedidoProdutoID = int.Parse(auxSQL.retornaDataTable("SELECT MAX(ID) FROM PEDIDO_PRODUTO WHERE PEDIDO = " + pedidoID).Rows[0][0].ToString());
                        auxSQL.insertPagamentoPedidoID(pedidoProdutoID, double.Parse(dtGrid.Rows[i]["VL_TOTAL"].ToString()), tipoPagamento);

                        if (tipoPagamento == 5)
                        {
                            auxSQL.insertPagamentoNota(pedidoProdutoID, cboAnotar.SelectedItem.ToString()) ;
                        }

                    }
                    this.Close();
                }
            }
        }

        private void TxtVlRecebido_TextChanged(object sender, EventArgs e)
        {
            if (tipoPagamento == 1 && !string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                double aux = double.Parse(txtVlRecebido.Text) - double.Parse(txtVlTotal.Text);
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

        private void CboProdutoFilho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdutoFilho.SelectedItem.Equals("SORVETE KILO"))
            {
                txtQuantidade.TipoCampo = "DOUBLE";
            }
            else
            {
                txtQuantidade.TipoCampo = "INTEIRO";
            }
        }
    }
}
