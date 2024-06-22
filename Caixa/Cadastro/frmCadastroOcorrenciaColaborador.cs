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

namespace Caixa.Cadastro
{
    public partial class frmCadastroOcorrenciaColaborador : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private string colaborador = "", ocorrencia = "";
        public frmCadastroOcorrenciaColaborador()
        {
            InitializeComponent();

            dtpData.Value = DateTime.Now;
            preencherCampos();

            cboColaborador.Items.Add("SELECIONE AQUI");
            cboFiltroColaborador.Items.Add("SELECIONE AQUI");

            DataTable dtNomes = auxSQL.retornaDataTable("SELECT NOME FROM COLABORADOR");
            for (int i = 0; i < dtNomes.Rows.Count; i++)
            {
                cboColaborador.Items.Add(dtNomes.Rows[i]["NOME"].ToString());
                cboFiltroColaborador.Items.Add(dtNomes.Rows[i]["NOME"].ToString());
            }

            cboColaborador.SelectedIndex = 0;
            cboFiltroColaborador.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                colaborador = cboColaborador.SelectedItem.ToString();
                ocorrencia = txtDesOcorrencia.Text;

                auxSQL.insertColaboradorOcorrencia(colaborador, ocorrencia, dtpData.Value);

                preencherCampos();
                txtDesOcorrencia.Text = "";
                cboColaborador.SelectedIndex = 0;
            }
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtDesOcorrencia.Text))
                return false;
            if (cboColaborador.SelectedIndex < 1)
                return false;

            return true;

        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CO.ID, C.NOME, CO.DESCRICAO, CO.DATA ");
            sql.Append("FROM COLABORADOR_OCORRENCIA CO ");
            sql.Append("JOIN COLABORADOR C ON(CO.ID_COLABORADOR = C.ID) ");
            if (cboFiltroColaborador.SelectedIndex > 0)
                sql.Append(" WHERE C.NOME LIKE '" + cboFiltroColaborador.SelectedItem.ToString() + "'");

                dgvOcorrencias.DataSource = auxSQL.retornaDataTable(sql.ToString());
        }
    }
}
