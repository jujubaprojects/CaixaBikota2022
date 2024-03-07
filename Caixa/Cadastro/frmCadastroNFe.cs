using Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa.Cadastro
{
    public partial class frmCadastroNFe : FormJCS
    {
        private bool firstInsert = true;
        private int idFornecedor = 0, qt_Com = 0, idNF = 0;
        private string inf_nfe = "", n_nf = "", desc_Prod = "", cod_Prod = "", un_Comercial = "";
        private DateTime dtEmissao, dtEntrega;
        private bool cupomFiscal = true;
        private double vlNF = 0, vl_Unit = 0;
        private SqlConnection conn;
        private SqlTransaction transacao;
        private dal.Conexao conexao = new dal.Conexao();
        private SQL.SQL auxSQL = new SQL.SQL();
        public frmCadastroNFe()
        {
            InitializeComponent();
        }
        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM FORNECEDOR ");
            frmBusca frm = new frmBusca(sql, "Busca Fornecedores");
            frm.ShowDialog();

            if (frm.retorno != null)
            {
                idFornecedor = int.Parse(frm.retorno["ID"].ToString());
                txtIDFornecedor.Text = idFornecedor.ToString();
                txtFornecedor.Text = frm.retorno["NOME"].ToString();
            }
            else
            {
                idFornecedor = 0;
                txtIDFornecedor.Text = "";
                txtFornecedor.Text = "";
            }
        }

        private void TxtNumeroNFe_Leave(object sender, EventArgs e)
        {
            if (idFornecedor > 0)
            {
                if (auxSQL.retornaDataTable("SELECT * FROM NF WHERE FORNECEDOR = " + txtIDFornecedor.Text + " N_NF LIKE " + txtNumeroNFe.Text).Rows.Count > 0)
                {
                    MessageBox.Show("NFe já cadastrada.", "NFe duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumeroNFe.Text = "";
                }
            }
        }

        private void TxtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProduto.Text) && !string.IsNullOrEmpty(txtFornecedor.Text))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT NFP.* ");
                sql.Append("FROM NF_PROD NFP ");
                sql.Append("JOIN NF NF ON(NF.id = NFP.NF) ");
                sql.Append("WHERE NF.FORNECEDOR = " + idFornecedor + " AND NFP.COD_PROD = " + txtCodProduto.Text);
                DataTable dt = auxSQL.retornaDataTable(sql.ToString());
                if (dt.Rows.Count > 0)
                    txtDescProduto.Text = dt.Rows[0]["DESC_PROD"].ToString();
                else
                    txtDescProduto.Text = "";
            }
            else
                txtDescProduto.Text = "";
        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dgvProdutos.Columns["colExcluir"].Index && dgvProdutos.Rows.Count > 0 && e.RowIndex != dgvProdutos.Rows.Count)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM NF_PROD WHERE NF = @NF AND COD_PROD = @COD_PROD");

                SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                sqlc.CommandType = CommandType.Text;
                sqlc.Parameters.AddWithValue("@NF", dgvProdutos.Rows[e.RowIndex].Cells["colNFID"].Value);
                sqlc.Parameters.AddWithValue("@COD_PROD", dgvProdutos.Rows[e.RowIndex].Cells["colCodProd"].Value);
                auxSQL.executaQueryTransaction(conn, sqlc); //DESCOMENTAR DEPOIS

                preencherGrid();

                //dtGrid.Rows[e.RowIndex].Delete();
                //preencherDgv(dtGrid);
            }
        }

        private void FrmCadastroNFe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transacao != null && transacao.Connection.State == ConnectionState.Open)
            {
                transacao.Rollback();
                conn.Close();
            }
        }

        private void TxtIDFornecedor_Leave(object sender, EventArgs e)
        {
            DataTable dtFornecedor = null;

            if (transacao != null && transacao.Connection.State == ConnectionState.Open)
            {
                if (!string.IsNullOrEmpty(txtIDFornecedor.Text))
                {
                    SqlCommand sqlc = new SqlCommand("SELECT ID, NOME FROM FORNECEDOR WHERE ID = " + txtIDFornecedor.Text, conn, transacao);
                    //sqlc.CommandType = CommandType.Text;
                    dtFornecedor = auxSQL.retornaDataTableTransaction(conn, sqlc);           
                }
                else
                    txtFornecedor.Text = "";
            }
            else
            {
                dtFornecedor = auxSQL.retornaDataTable("SELECT ID, NOME FROM FORNECEDOR WHERE ID = " + txtIDFornecedor.Text);
            }

            if (dtFornecedor.Rows.Count > 0)
            {
                txtFornecedor.Text = dtFornecedor.Rows[0]["NOME"].ToString();
                idFornecedor = int.Parse(txtIDFornecedor.Text);
            }
            else
            {
                txtFornecedor.Text = "";
                idFornecedor = 0;
            }
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (firstInsert)
                {
                    conn = conexao.retornaConexao();
                    transacao = conexao.startTransaction(conn);
                }
                var teste = transacao.Connection.State;
                StringBuilder sql = new StringBuilder();

                try
                {
                    if (firstInsert)
                    {
                        sql.Append("INSERT INTO NF(INF_NFE, COD_NF, N_NF, DT_EMISSAO, DT_ENTREGA, FORNECEDOR, VALOR) ");
                        sql.Append("VALUES (@INF_NFE, IDENT_CURRENT ('NF') + 1, @N_NF, @DT_EMISSAO, @DT_ENTREGA, @FORNECEDOR, @VALOR) ");
                        SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                        sqlc.CommandType = CommandType.Text;
                        sqlc.Parameters.AddWithValue("@INF_NFE", inf_nfe);
                        sqlc.Parameters.AddWithValue("@N_NF", n_nf);
                        sqlc.Parameters.AddWithValue("@DT_EMISSAO", dtEmissao);
                        sqlc.Parameters.AddWithValue("@DT_ENTREGA", dtEntrega);
                        sqlc.Parameters.AddWithValue("@FORNECEDOR", idFornecedor);
                        sqlc.Parameters.AddWithValue("@VALOR", vlNF);
                        auxSQL.executaQueryTransaction(conn, sqlc); //DESCOMENTAR DEPOIS
                        firstInsert = false;
                    }

                    sql.Clear();
                    sql.Append("INSERT INTO NF_PROD (NF, COD_PROD, DESC_PROD, QT_COM, VL_UNIT, UN_COMERCIAL) ");
                    sql.Append("VALUES ((select max(id) from nf), @COD_PROD, @DESC_PROD, @QT_COM, @VL_UNIT, @UN_COMERCIAL) ");
                    SqlCommand sqlc2 = new SqlCommand(sql.ToString(), conn, transacao);
                    sqlc2.CommandType = CommandType.Text;
                    sqlc2.Parameters.AddWithValue("@COD_PROD", cod_Prod);
                    sqlc2.Parameters.AddWithValue("@DESC_PROD", desc_Prod);
                    sqlc2.Parameters.AddWithValue("@QT_COM", qt_Com);
                    sqlc2.Parameters.AddWithValue("@VL_UNIT", vl_Unit);
                    sqlc2.Parameters.AddWithValue("@UN_COMERCIAL", un_Comercial);
                    auxSQL.executaQueryTransaction(conn, sqlc2); //DESCOMENTAR DEPOIS

                    preencherGrid();
                    //firstInsert = true;

                }
                catch (Exception err)
                {
                    //transacao.Rollback();
                    //conn.Close();
                    MessageBox.Show("Erro: " + err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //finally
                //{
                //    transacao.Commit();
                //    conn.Close();
                //}
            }
            else
            {
                MessageBox.Show("Verifique as informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void preencherGrid()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT NF, COD_PROD, DESC_PROD, QT_COM, VL_UNIT, UN_COMERCIAL  ");
            sql.Append("FROM NF_PROD ");
            sql.Append("WHERE NF = (SELECT MAX(ID) FROM NF) ");
            SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
            dgvProdutos.DataSource = auxSQL.retornaDataTableTransaction(conn, sqlc);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar a NFe/Cupom não fiscal?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    if (validarCampos() && dgvProdutos.Rows.Count > 0)
                    {
                        transacao.Commit();
                        conn.Close();

                        MessageBox.Show("NFe/Cupom não fiscal adicionado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Verifique as informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void limparCampos()
        {
            txtChave1.Text = "";
            txtChave2.Text = "";
            txtChave3.Text = "";
            txtChave4.Text = "";
            txtChave5.Text = "";
            txtChave6.Text = "";
            txtChave7.Text = "";
            txtChave8.Text = "";
            txtChave9.Text = "";
            txtChave10.Text = "";
            txtChave11.Text = "";
            txtCodProduto.Text = "";
            txtDescProduto.Text = "";
            txtFornecedor.Text = "";
            txtIDFornecedor.Text = "";
            txtNumeroNFe.Text = "";
            txtQtCom.Text = "";
            txtUnidComercial.Text = "";
            txtValorNFe.Text = "";
            txtVlUnit.Text = "";
            dgvProdutos.Rows.Clear();

            preencherParametros();
        }

        private void RbtCupomFiscal_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos(true);
            cupomFiscal = true;
        }

        private void RbtCupomNFiscal_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cupomFiscal = false;
        }

        private bool validarCampos()
        {
            if (cupomFiscal)
            {
                if (string.IsNullOrEmpty(txtChave1.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave2.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave3.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave4.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave5.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave6.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave7.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave8.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave9.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave10.Text))
                    return false;
                if (string.IsNullOrEmpty(txtChave11.Text))
                    return false;
            }

            if (string.IsNullOrEmpty(txtVlUnit.Text))
                return false;
            if (string.IsNullOrEmpty(txtQtCom.Text))
                return false;
            if (string.IsNullOrEmpty(txtUnidComercial.Text))
                return false;
            if (string.IsNullOrEmpty(txtNumeroNFe.Text))
                return false;

            preencherParametros();
            return true;
        }

        private void preencherParametros()
        {
            //NF.COD_NF = NF.ID
            //ID_FORNECEDOR JÁ FOI PREENCHIDO
            inf_nfe = txtChave1.Text + txtChave2.Text + txtChave3.Text + txtChave4.Text + txtChave5.Text + txtChave6.Text + txtChave7.Text + txtChave8.Text + txtChave9.Text + txtChave10.Text + txtChave11.Text;
            n_nf = txtNumeroNFe.Text;
            dtEmissao = DateTime.Parse(dtpEmissao.Text.ToString());
            dtEntrega = DateTime.Parse(dtpEntrega.Text.ToString());
            vlNF = double.Parse(txtValorNFe.Text.Replace("R$",""));

            cod_Prod = txtCodProduto.Text;
            desc_Prod = txtDescProduto.Text;
            qt_Com = int.Parse(txtQtCom.Text);
            vl_Unit = double.Parse(txtVlUnit.Text.Replace("R$",""));
            un_Comercial = txtUnidComercial.Text;
        }

        private void habilitarCampos(bool pParametro)
        {
            txtChave1.Enabled = pParametro;
            txtChave2.Enabled = pParametro;
            txtChave3.Enabled = pParametro;
            txtChave4.Enabled = pParametro;
            txtChave5.Enabled = pParametro;
            txtChave6.Enabled = pParametro;
            txtChave7.Enabled = pParametro;
            txtChave8.Enabled = pParametro;
            txtChave9.Enabled = pParametro;
            txtChave10.Enabled = pParametro;
            txtChave11.Enabled = pParametro;
        }
    }
}
