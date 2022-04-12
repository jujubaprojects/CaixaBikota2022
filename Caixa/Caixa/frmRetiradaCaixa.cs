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

namespace Caixa.Caixa
{
    public partial class frmRetiradaCaixa : FormJCS
    {
        private SqlConnection conn;
        private dal.Conexao conexao = new dal.Conexao();
        private SQL.SQL auxSQL = new SQL.SQL();

        public frmRetiradaCaixa()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                try
                {

                    conn = conexao.retornaConexao();
                    string sql = "INSERT INTO RETIRADA_CAIXA (DESCRICAO, VALOR, DATA) VALUES (@pDescricao, @pValor, getdate())";
                    SqlCommand sqlc = new SqlCommand(sql, conn);
                    sqlc.CommandType = CommandType.Text;
                    sqlc.Parameters.AddWithValue("@pDescricao", txtDescricao.Text);
                    sqlc.Parameters.AddWithValue("@pValor", double.Parse(txtValor.Text.Trim().Replace("R$", "")));
                    auxSQL.executaQueryTransaction(conn, sqlc);

                    MessageBox.Show("Informação salva na base de dados!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show("Contate o suporte para verificar o erro: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }

            }
            else
                MessageBox.Show("Verifique se os campos estão preenchidos corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text.Trim()))
                return false;
            if (string.IsNullOrEmpty(txtValor.Text.Trim()) || double.Parse(txtValor.Text.Trim().Replace("R$", "")) <= 0)
                return false;

            return true;
        }

        private void LblValor_Click(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
