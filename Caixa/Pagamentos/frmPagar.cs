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
    public partial class frmPagar : FormJCS
    {
        private string pedidos;
        private dal.Conexao conexao = new dal.Conexao();
        private int tipoPagamento = 0; //1 = DINHEIRO; 2 = CARTAO CREDITO; 3 = CARTAO DEBITO; 4 = PIX; 5 = ANOTAR
        private bool marcarTodos = false;
        private int pedidoID;
        private SQL.SQL auxSql = new SQL.SQL();
        private double vlDividido = 0;
        private int qtLinhaSel = 0;
        private bool vlHaver = false;
        private double vlTotalPedidoAberto = 0;
        private double vlProdutosSemHaver = 0;
        private bool controleEsc = true;
        private double auxVlAberto = 0;
        private bool vlHaverNovo = false;

        public frmPagar(int pPedidoID, string pPedidos, bool pTipo, double pVlAbertoTotalPedido)
        {
            InitializeComponent();
            this.pedidos = pPedidos;
            this.marcarTodos = pTipo;
            this.pedidoID = pPedidoID;
            this.vlTotalPedidoAberto = pVlAbertoTotalPedido;

            preencherCampos();

            cboTipoPagamento.SelectedIndex = 0;
        }

        private void preencherCampos()
        {

            DataTable dt = auxSql.buscaPedidosProdutosAberto(pedidos, marcarTodos);
            dgvPedProdAberto.DataSource = dt;

            for (int i =0; i < dt.Rows.Count; i++)
            {
                auxVlAberto += double.Parse(dt.Rows[i]["VL_ABERTO"].ToString());
            }

            txtValorAberto.Text = auxVlAberto.ToString("0.00");
        }

        private void escondeCampos()
        {
            cboAnotar.Visible = false;
            cboAnotar.Items.Clear();

            if (tipoPagamento == 5)
            {
                lblAnotou.Visible = true;
                cboAnotar.Visible = true;

                DataTable dt = auxSql.buscaClienteID(0,1);
                for (int i = 0; i < dt.Rows.Count; i++)
                    cboAnotar.Items.Add(dt.Rows[i]["NOME"].ToString());
            }

            if (vlHaver)
            {
                lblTroco.Visible = false;
                txtVlRecebido.Enabled = true;
            }
            else
            {
                if (tipoPagamento == 1)
                {
                    lblTroco.Visible = true;
                    txtVlRecebido.Enabled = true;
                }
                else
                {
                    lblTroco.Visible = false;
                    txtVlRecebido.Enabled = false;
                    txtVlRecebido.Text = txtValorAberto.Text;
                }
            }
        }

        private void CboTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPagamento = int.Parse(auxSql.retornaDataTable("SELECT ID FROM TIPO_PAGAMENTO WHERE DESCRICAO LIKE '" + cboTipoPagamento.SelectedItem.ToString() + "'").Rows[0][0].ToString() );
            escondeCampos();
        }

        private bool validaCampos()
        {         
            if (tipoPagamento == 5)
            {
                if (cboAnotar.SelectedIndex < 0)
                {
                    MessageBox.Show("Informe o nome da pessoa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (auxSql.buscaClienteInativo(cboAnotar.SelectedItem.ToString()).Rows.Count > 0)
                {
                    MessageBox.Show("Cliente inativo, por favor fale com o responsável!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (cboTipoPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o tipo de pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tipoPagamento == 1 && string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                MessageBox.Show("Informe o valor recebido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (double.Parse(txtValorAberto.Text) > double.Parse(txtVlRecebido.Text))
            {
                MessageBox.Show("Valor Recebido menor que Valor Aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (double.Parse(txtValorAberto.Text) > vlTotalPedidoAberto)
            {
                MessageBox.Show("Existe valores em haver na tela anterior.\nPor favor, selecione todos os produtos da tela anterior!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (vlHaver && double.Parse(txtVlRecebido.Text) > vlTotalPedidoAberto)
            {
                MessageBox.Show("Não existe mais produtos em aberto para deixar o valor em haver!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (vlHaver && double.Parse(txtValorAberto.Text) == double.Parse(txtVlRecebido.Text))
            {
                MessageBox.Show("Para deixar um valor em haver, o valor recebido precisa ser maior que o valor aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
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

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                percorrerGridSalvandoVl();
                Close();
            }
        }

        private void DgvPedProdAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvPedProdAberto.Columns["colChkDividir"].Index && dgvPedProdAberto.Rows.Count > 0 && e.RowIndex != dgvPedProdAberto.Rows.Count)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("PED_PROD_ID");
                dt.Columns.Add("PRODUTO");
                dt.Columns.Add("DESC_PRODUTO");
                dt.Columns.Add("VL_ABERTO");
                dt.Columns.Add("CHKDIVIDIR");

                for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
                {
                    if (e.RowIndex == i)
                        dt.Rows.Add(dgvPedProdAberto["colPedidoProdutoID", e.RowIndex].Value, dgvPedProdAberto["colProduto", e.RowIndex].Value, dgvPedProdAberto["colDescricao", e.RowIndex].Value, dgvPedProdAberto["colValor", e.RowIndex].Value, !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString()));
                    else
                        dt.Rows.Add(dgvPedProdAberto["colPedidoProdutoID", i].Value, dgvPedProdAberto["colProduto", i].Value, dgvPedProdAberto["colDescricao", i].Value, dgvPedProdAberto["colValor", i].Value, bool.Parse(dgvPedProdAberto["colChkDividir",i].Value.ToString()));
                }

                dgvPedProdAberto.DataSource = dt;

                //dgvPedProdAberto["colChkDividir", e.RowIndex].Value = !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString());

                //if (dgvPedProdAberto["colChkDividir", e.RowIndex].Value == null || !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString()))
                //    dgvPedProdAberto["colChkDividir", e.RowIndex].Value = true;     
                //else
                //    dgvPedProdAberto["colChkDividir", e.RowIndex].Value = !bool.Parse(dgvPedProdAberto["colChkDividir", e.RowIndex].Value.ToString());
                
            }
        }

        private void BtnDividirPagamento_Click(object sender, EventArgs e)
        {
            qtLinhaSel = 0;
            double vlAberto = 0;
            string pedidos = "";
            double vlTotalAberto = 0;
            for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
            {
                if ((dgvPedProdAberto["colChkDividir", i].Value != null && bool.Parse(dgvPedProdAberto["colChkDividir", i].Value.ToString())))
                {
                    qtLinhaSel++;
                    if (double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()) != 0)
                    {
                        vlAberto += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                        pedidos += dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString() + ",";
                    }
                }
                else
                {
                    vlTotalAberto += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                    vlProdutosSemHaver += double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                }
            }

            if (vlAberto > 0)
            {
                pedidos = pedidos.Substring(0, pedidos.Length - 1);
                frmPagarDividido frm = new frmPagarDividido(pedidos, vlAberto);
                frm.ShowDialog();

                if (frm.vlRecebido > 0)
                {
                    dgvPedProdAberto.Enabled = false;
                    dgvPedProdAberto.Sort(dgvPedProdAberto.Columns["colChkDividir"], ListSortDirection.Ascending);

                    vlDividido = frm.vlRecebido;
                    //txtValorAberto.Text = (double.Parse(txtValorAberto.Text) - vlDividido).ToString();
                    txtValorAberto.Text = (vlTotalAberto + vlDividido).ToString();

                    if (tipoPagamento != 1)
                        txtDescPagamento.Text = txtValorAberto.Text;
                }
            }


            if (double.Parse(txtValorAberto.Text) > auxVlAberto)
            {
                DialogResult result = MessageBox.Show("Deseja pagar o valor a mais que os produtos selecionados?", "Valor em Haver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        vlHaverNovo = true;
                    }

                }
            }

        }

        private void percorrerGridSalvandoVl()
        {
            double auxVl = 0;
            if (vlHaver)
                auxVl = double.Parse(txtVlRecebido.Text);
            else
                auxVl = double.Parse(txtValorAberto.Text);

            double vlInserir = 0;
            double vlPago = double.Parse(txtVlRecebido.Text);
            double vlAberto = double.Parse(txtValorAberto.Text);
            double vlInserido = 0;
            for (int i = 0; i < dgvPedProdAberto.Rows.Count; i++)
            {
                if (auxVl > 0)
                {
                    if (i + 1 == dgvPedProdAberto.Rows.Count && vlHaver)
                    {
                        inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), auxVl); //descomentar ao colocar em producao
                        auxVl = 0;
                    }

                    if (auxVl > 0)
                    {
                        if (auxVl >= double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()) || qtLinhaSel > i)
                        {
                            //if (qtLinhaSel >= i + 1)
                            //{
                            //    if (vlHaver)
                            //        vlInserir = Math.Round((double.Parse(txtVlRecebido.Text) - vlProdutosSemHaver) / qtLinhaSel,4);
                            //    else
                            //        vlInserir = Math.Round(vlDividido / qtLinhaSel,4);
                            //}
                            //else
                            //    vlInserir = Math.Round(double.Parse(dgvPedProdAberto["colValor", i].Value.ToString()), 4);

                            //auxVl -= vlInserir;
                            //vlInserido += vlInserir;                            
                            //inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), vlInserir); //descomentar ao colocar em producao
                            
                            vlInserir = double.Parse(dgvPedProdAberto["colValor", i].Value.ToString());
                            if (vlInserir > 0)
                            {
                                if (vlInserir > auxVl)
                                    vlInserir = auxVl;
                                auxVl -= vlInserir;
                                vlInserido += vlInserir;
                                inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), vlInserir); //descomentar ao colocar em producao

                                if (vlHaverNovo && dgvPedProdAberto.Rows.Count == i + 1)
                                    inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), auxVl); //descomentar ao colocar em producao
                            }
                        }
                        else
                        {
                            //verificaSeExisteEstoque(dgvPedProdAberto["colProduto", i].Value.ToString(), dgvPedProdAberto["colDescricao", i].Value.ToString());
                            inserirPagamento(dgvPedProdAberto["colPedidoProdutoID", i].Value.ToString(), auxVl); //descomentar ao colocar em producao
                            auxVl = 0;
                        }
                    }
                }
            }


        }

        private void verificaSeExisteEstoque(string pProduto, string pDescricao)
        {
            try
            {
                if (pProduto.Equals("POTE 04L") || pProduto.Equals("POTE 05L") || pProduto.Equals("POTE 10L"))
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT EP.* ");
                    sql.Append("FROM ESTOQUE_POTE EP ");
                    sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
                    sql.Append("WHERE P.DESCRICAO = '" + pProduto + "' ");
                    sql.Append("AND dbo.RETORNA_SABORES(EP.ID) LIKE '" + pDescricao + "' ");
                    if (auxSql.retornaDataTable(sql.ToString()).Rows.Count == 0)
                    {
                        List<string> listaOrdernada = pDescricao.Split(',').ToList();
                        auxSql.insertEstoquePoteZerado(pProduto);


                        //FOI DELETADO A PK PK_SABOR_ESTOQUE -> A PK É DA COLUNA ID_EST_POTE E ID_SABOR. 1 PK PARA 2 COLUNAS
                        for (int i = 0; i < listaOrdernada.Count; i++)
                        {
                            auxSql.insertEstoquePoteSaborUltimoRegistro(listaOrdernada[i]);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar estoque de pote zerado.", "Fale com o suporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inserirPagamento (string pID, double pValor)
        {
            auxSql.insertPagamento(int.Parse(pID), pValor, tipoPagamento);
            //conexao.executarInsUpDel(auxSql.queryInsertPagamento(pID,pValor, tipoPagamento));

            if (tipoPagamento == 5)
            {                
                auxSql.insertPagamentoNota(int.Parse(pID), cboAnotar.SelectedItem.ToString());
            }

            if (double.Parse(txtValorAberto.Text.ToString()) == 0)
            {
                auxSql.updateSituacaoPedido(pedidoID, null, 4);
            }
        }

        private void TxtVlRecebido_TextChanged(object sender, EventArgs e)
        {
            if (tipoPagamento == 1 && !string.IsNullOrEmpty(txtVlRecebido.Text))
            {
                double aux = double.Parse(txtVlRecebido.Text) - double.Parse(txtValorAberto.Text);
                if (aux >= 0)
                    lblTroco.Text = "Troco R$ " + aux.ToString("0.00");
            }
        }

        private void ChkVlHaver_CheckedChanged(object sender, EventArgs e)
        {
            vlHaver = chkVlHaver.Checked;
            escondeCampos();


        }

        private void FrmPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && controleEsc)
                this.Close();
            else
                controleEsc = false;
        }

        private void FrmPagar_MouseEnter(object sender, EventArgs e)
        {
            controleEsc = false;
            this.MouseEnter -= FrmPagar_MouseEnter;
        }
    }
}
