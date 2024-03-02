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
        private bool firstInsert = false;
        private int idFornecedor = 0, qt_Com = 0;
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
                idFornecedor = int.Parse(frm.retorno["ID"].ToString()); ;
                txtFornecedor.Text = frm.retorno["NOME"].ToString();
            }
            else
            {
                idFornecedor = 0;
                txtFornecedor.Text = "";
            }
        }

        private void TxtNumeroNFe_Leave(object sender, EventArgs e)
        {
            if (auxSQL.retornaDataTable("SELECT * FROM NF WHERE N_NF LIKE " + txtNumeroNFe.Text).Rows.Count > 0)
            {
                MessageBox.Show("NFe já cadastrada.", "NFe duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroNFe.Text = "";
            }
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                conn = conexao.retornaConexao();
                transacao = conexao.startTransaction(conn);

                StringBuilder sql = new StringBuilder();

                try
                {
                    if (firstInsert)
                    {
                        sql.Append("INSERT INTO NF(INF_NFE, COD_NF, N_NF, DT_EMISSAO, DT_ENTREGA, FORNECEDOR, VALOR) ");
                        sql.Append("VALUES (@INF_NFE, (select max(id) + 1 from nf), @N_NF, @DT_EMISSAO, @DT_ENTREGA, @FORNECEDOR, @VALOR) ");
                        SqlCommand sqlc = new SqlCommand(sql.ToString(), conn, transacao);
                        sqlc.CommandType = CommandType.Text;
                        sqlc.Parameters.AddWithValue("@INF_NFE", inf_nfe);
                        sqlc.Parameters.AddWithValue("@N_NF", n_nf);
                        sqlc.Parameters.AddWithValue("@DT_EMISSAO", dtEmissao);
                        sqlc.Parameters.AddWithValue("@DT_ENTREGA", dtEntrega);
                        sqlc.Parameters.AddWithValue("@FORNECEDOR", idFornecedor);
                        sqlc.Parameters.AddWithValue("@VALOR", vlNF);
                        auxSQL.executaQueryTransaction(conn, sqlc); //DESCOMENTAR DEPOIS
                        firstInsert = true;
                    }

                    DataTable dtTeste = auxSQL.retornaDataTable("SELECT * FROM NF ORDER BY ID DESC");

                    sql.Clear();
                    sql.Append("INSERT INTO NF_PROD (NF, COD_PROD, DESC_PROD, QT_COM, VL_UNIT, UN_COMERCIAL) ");
                    sql.Append("VALUES ((SELECT MAX(ID) FROM NF), @COD_PROD, @DESC_PROD, @QT_COM, @VL_UNIT, @UN_COMERCIAL) ");
                    SqlCommand sqlc2 = new SqlCommand(sql.ToString(), conn, transacao);
                    sqlc2.CommandType = CommandType.Text;
                    sqlc2.Parameters.AddWithValue("@COD_PROD", cod_Prod);
                    sqlc2.Parameters.AddWithValue("@DESC_PROD", desc_Prod);
                    sqlc2.Parameters.AddWithValue("@QT_COM", qt_Com);
                    sqlc2.Parameters.AddWithValue("@VL_UNIT", vl_Unit);
                    sqlc2.Parameters.AddWithValue("@UN_COMERCIAL", un_Comercial);
                    auxSQL.executaQueryTransaction(conn, sqlc2); //DESCOMENTAR DEPOIS
                    firstInsert = true;

                }
                catch (Exception err)
                {
                    transacao.Rollback();
                    conn.Close();
                    MessageBox.Show("Erro: " + err.InnerException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                finally
                {
                    transacao.Commit();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && dgvProdutos.Rows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Verifique as informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                if (string.IsNullOrEmpty(txtNumeroNFe.Text))
                    return false;
            }

            if (string.IsNullOrEmpty(txtVlUnit.Text))
                return false;
            if (string.IsNullOrEmpty(txtQtCom.Text))
                return false;
            if (string.IsNullOrEmpty(txtUnidComercial.Text))
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
            vlNF = double.Parse(txtValorNFe.Text);

            cod_Prod = txtCodProduto.Text;
            desc_Prod = txtDescProduto.Text;
            qt_Com = int.Parse(txtQtCom.Text);
            vl_Unit = double.Parse(txtVlUnit.Text);
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
            txtNumeroNFe.Enabled = pParametro;
        }
    }
}
