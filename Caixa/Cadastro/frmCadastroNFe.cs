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
        private bool firstInsert = true;//, auxEventTxTChanged = false;
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
            if (!string.IsNullOrEmpty(txtCodProduto.Text) && !string.IsNullOrEmpty(txtFornecedor.Text) && !chkProdSemCod.Checked)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT NFP.* ");
                sql.Append("FROM NF_PROD NFP ");
                sql.Append("JOIN NF NF ON(NF.id = NFP.NF) ");
                sql.Append("WHERE NF.FORNECEDOR = " + idFornecedor + " AND NFP.COD_PROD = " + txtCodProduto.Text);
                DataTable dt;

                if (dgvProdutos.Rows.Count <= 0)
                    dt = auxSQL.retornaDataTable(sql.ToString());
                else
                {
                    SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                    dt = auxSQL.retornaDataTableTransaction(conn, sqlc);
                }


                if (dt.Rows.Count > 0)
                {
                    txtDescProduto.Text = dt.Rows[0]["DESC_PROD"].ToString();
                    txtDescProduto.Enabled = false;
                    //auxEventTxTChanged = false;
                }
                else
                {
                    txtDescProduto.Text = "";
                    txtDescProduto.Enabled = true;
                    //auxEventTxTChanged = true;
                }
            }
            else
            {
                txtDescProduto.Text = "";
                txtDescProduto.Enabled = true;
                //auxEventTxTChanged = true;
            }
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
            if (transacao != null && transacao.Connection != null && transacao.Connection.State != null && transacao.Connection.State == ConnectionState.Open)
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
                if (!string.IsNullOrEmpty(txtIDFornecedor.Text.Trim()))
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
                if (!string.IsNullOrEmpty(txtIDFornecedor.Text.Trim()))
                {
                    dtFornecedor = auxSQL.retornaDataTable("SELECT ID, NOME FROM FORNECEDOR WHERE ID = " + txtIDFornecedor.Text);
                }
            }

            if (dtFornecedor != null && dtFornecedor.Rows.Count > 0)
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
            if (validarCampos(1))
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

                    //sql.Clear();
                    //if (chkProdSemCod.Checked && string.IsNullOrEmpty(txtCodProduto.Text))
                    //{
                    //    sql.Append("SELECT ISNULL(MAX(NFP.COD_PROD),0) + 1 ");
                    //    sql.Append("FROM NF_PROD NFP ");
                    //    sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
                    //    sql.Append("JOIN fornecedor F ON(F.ID = NF.FORNECEDOR) ");
                    //    sql.Append("WHERE F.ID = @FORNECEDOR ");
                    //    SqlCommand sqlCodProd = new SqlCommand(sql.ToString(), conn, transacao);
                    //    sqlCodProd.Parameters.AddWithValue("@FORNECEDOR", idFornecedor);
                    //    cod_Prod = auxSQL.retornaDataTableTransaction(conn, sqlCodProd).Rows[0][0].ToString();
                    //}

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

                    txtCodProduto.Text = "";
                    txtDescProduto.Text = "";
                    txtUnidComercial.Text = "";
                    txtQtCom.Text = "";
                    txtVlUnit.Text = "";
                    chkProdSemCod.Checked = false;
                    //firstInsert = true;
                    txtCodProduto.Focus();
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

        private void TxtChave1_TextChanged(object sender, EventArgs e)
        {
            if (txtChave1.Text.Count() == 4)
                txtChave2.Focus();
        }

        private void TxtChave2_TextChanged(object sender, EventArgs e)
        {
            if (txtChave2.Text.Count() == 4)
                txtChave3.Focus();

        }

        private void TxtChave3_TextChanged(object sender, EventArgs e)
        {

            if (txtChave3.Text.Count() == 4)
                txtChave4.Focus();
        }

        private void TxtChave4_TextChanged(object sender, EventArgs e)
        {

            if (txtChave4.Text.Count() == 4)
                txtChave5.Focus();
        }

        private void TxtChave5_TextChanged(object sender, EventArgs e)
        {
            if (txtChave5.Text.Count() == 4)
                txtChave6.Focus();

        }

        private void TxtChave6_TextChanged(object sender, EventArgs e)
        {
            if (txtChave6.Text.Count() == 4)
                txtChave7.Focus();

        }

        private void TxtChave7_TextChanged(object sender, EventArgs e)
        {
            if (txtChave7.Text.Count() == 4)
                txtChave8.Focus();

        }

        private void TxtChave8_TextChanged(object sender, EventArgs e)
        {
            if (txtChave8.Text.Count() == 4)
                txtChave9.Focus();

        }

        private void TxtChave9_TextChanged(object sender, EventArgs e)
        {
            if (txtChave9.Text.Count() == 4)
                txtChave10.Focus();

        }

        private void TxtChave10_TextChanged(object sender, EventArgs e)
        {
            if (txtChave10.Text.Count() == 4)
                txtChave11.Focus();

        }

        private void ChkProdSemCod_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProdSemCod.Checked)
            {
                btnAddProdSemCod.Enabled = true;
                btnAddProduto.Enabled = false;
            }
            else
            {
                btnAddProdSemCod.Enabled = false;
                btnAddProduto.Enabled = true;
            }
        }

        private void BtnAddProdSemCod_Click(object sender, EventArgs e)
        {
            if (validarCampos(1))
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
                    if (chkProdSemCod.Checked)
                    {
                        sql.Append("SELECT ISNULL(MAX(NFP.COD_PROD),0) + 1 ");
                        sql.Append("FROM NF_PROD NFP ");
                        sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
                        sql.Append("JOIN fornecedor F ON(F.ID = NF.FORNECEDOR) ");
                        sql.Append("WHERE F.ID = @FORNECEDOR ");
                        SqlCommand sqlCodProd = new SqlCommand(sql.ToString(), conn, transacao);
                        sqlCodProd.Parameters.AddWithValue("@FORNECEDOR", idFornecedor);
                        cod_Prod = auxSQL.retornaDataTableTransaction(conn, sqlCodProd).Rows[0][0].ToString();
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

                    txtCodProduto.Text = "";
                    txtDescProduto.Text = "";
                    txtUnidComercial.Text = "";
                    txtQtCom.Text = "";
                    txtVlUnit.Text = "";
                    chkProdSemCod.Checked = false;
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

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFornecedor.Text))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT DISTINCT NFP.COD_PROD CODIGO, NFP.DESC_PROD PRODUTO ");
                sql.Append("FROM NF_PROD NFP ");
                sql.Append("JOIN NF ON(NF.ID = NFP.NF) ");
                sql.Append("WHERE NF.FORNECEDOR = " + txtIDFornecedor.Text);
                frmBusca frm = new frmBusca(sql, "Busca Produtos " + txtFornecedor.Text);
                frm.ShowDialog();

                if (frm.retorno != null)
                {
                    txtCodProduto.Text = frm.retorno["CODIGO"].ToString();
                    txtDescProduto.Text = frm.retorno["PRODUTO"].ToString();
                    txtDescProduto.Enabled = false;
                }
                else
                {
                    txtCodProduto.Text = "";
                    txtDescProduto.Text = "";
                    txtDescProduto.Enabled = true;
                }
            }
            else
                MessageBox.Show("Informe um fornecedor antes de consultar os produtos", "Necessário Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void TxtDescProduto_TextChanged(object sender, EventArgs e)
        //{
        //    if (auxEventTxTChanged || (!string.IsNullOrEmpty(txtDescProduto.Text) && !string.IsNullOrEmpty(txtFornecedor.Text)))
        //    {
        //        StringBuilder sql = new StringBuilder();
        //        sql.Append("SELECT NFP.* ");
        //        sql.Append("FROM NF_PROD NFP ");
        //        sql.Append("JOIN NF NF ON(NF.id = NFP.NF) ");
        //        sql.Append("WHERE NF.FORNECEDOR = " + idFornecedor + " AND NFP.DESC_PROD = '" + txtDescProduto.Text + "' ");
        //        DataTable dt;

        //        if (dgvProdutos.Rows.Count <= 0)
        //            dt = auxSQL.retornaDataTable(sql.ToString());
        //        else
        //        {
        //            SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
        //            dt = auxSQL.retornaDataTableTransaction(conn, sqlc);
        //        }

        //        if (dt.Rows.Count > 0)
        //        {
        //            txtCodProduto.Text = dt.Rows[0]["COD_PROD"].ToString();
        //            auxEventTxTChanged = false; 
        //        }
        //        else
        //        {
        //            txtCodProduto.Text = "";
        //            auxEventTxTChanged = true;
        //        }
        //    }
        //    else
        //    {
        //        txtCodProduto.Text = "";
        //        auxEventTxTChanged = true;
        //    }
        //}

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
                    if (validarCampos(2) && dgvProdutos.Rows.Count > 0)
                    {
                        transacao.Commit();
                        conn.Close();

                        MessageBox.Show("NFe/Cupom não fiscal adicionado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
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

            preencherParametros(0);
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

        private bool validarCampos(int pTipo) //1 = salvar produto; 2 = salvar nota fiscal
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

            if (pTipo == 1)
            {
                if (string.IsNullOrEmpty(txtVlUnit.Text))
                    return false;
                if (string.IsNullOrEmpty(txtQtCom.Text))
                    return false;
                if (string.IsNullOrEmpty(txtUnidComercial.Text))
                    return false;
                if (string.IsNullOrEmpty(txtNumeroNFe.Text))
                    return false;
            }

            if (pTipo == 2 && dgvProdutos.Rows.Count <= 0)
                return false;

            preencherParametros(pTipo);
            return true;
        }

        private void preencherParametros(int pTipo)//1 = salvar produto; 2 = salvar nota fiscal
        {
            //NF.COD_NF = NF.ID
            //ID_FORNECEDOR JÁ FOI PREENCHIDO
            inf_nfe = txtChave1.Text + txtChave2.Text + txtChave3.Text + txtChave4.Text + txtChave5.Text + txtChave6.Text + txtChave7.Text + txtChave8.Text + txtChave9.Text + txtChave10.Text + txtChave11.Text;
            n_nf = txtNumeroNFe.Text;
            dtEmissao = DateTime.Parse(dtpEmissao.Text.ToString());
            dtEntrega = DateTime.Parse(dtpEntrega.Text.ToString());
            vlNF = double.Parse(txtValorNFe.Text.Replace("R$",""));

            if (pTipo == 1)
            {
                cod_Prod = txtCodProduto.Text;
                desc_Prod = txtDescProduto.Text;
                qt_Com = int.Parse(txtQtCom.Text);
                vl_Unit = double.Parse(txtVlUnit.Text.Replace("R$", ""));
                un_Comercial = txtUnidComercial.Text;
            }
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
