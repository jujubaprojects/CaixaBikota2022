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
    public partial class frmCadastroSabor : frmCadastroJCS
    {
        private int id, status;
        private string descricao, nomeForm, tipo;

        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();
        public frmCadastroSabor()
        {
            InitializeComponent();

            nomeForm = this.Text;


            //btnNovo = toolStripNovoJCS;
            btnVoltar = toolStripVoltarJCS;
            btnEditar = toolStripEditarJCS;
            btnDeletar = toolStripDeletarJCS;
            btnSalvar = toolStripSalvarJCS;


            //tStrip.click += new EventHandler(toolStripNovoJCS_Click);
            //btnNovo.Click += new EventHandler(toolStripNovoJCS_Click);
            btnDeletar.Click += new EventHandler(toolStripDeletarJCS_Click);
            btnSalvar.Click += new EventHandler(toolStripSalvarJCS_Click);
            btnEditar.Click += new EventHandler(toolStripEditarJCS_Click);
            btnVoltar.Click += new EventHandler(toolStripVoltarJCS_Click);

            preencherCampos();
            preencherCombo();
        }

        private void preencherCombo()
        {
            DataTable dt = auxSQL.retornaDataTable("SELECT DISTINCT TIPO FROM SABOR ORDER BY 1");
            cboTipoFiltro.Items.Add("TODOS");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboTipoFiltro.Items.Add(dt.Rows[i]["TIPO"].ToString());
                cboTipo.Items.Add(dt.Rows[i]["TIPO"].ToString());
            }
            
        }
        private void preencherCampos()
        {
            string filtro = "WHERE 1 = 1 ";
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, TIPO, ATIVO FROM SABOR ");
            if (cboTipoFiltro.SelectedIndex != 0 && cboTipoFiltro.SelectedIndex > 0)
                filtro += "AND TIPO LIKE '" + cboTipoFiltro.SelectedItem + "' ";
            if (!string.IsNullOrEmpty(txtSaborFiltro.Text))
                filtro += "AND DESCRICAO LIKE '%" + txtSaborFiltro.Text + "%' ";
            sql.Append(filtro);
            sql.Append("ORDER BY TIPO, DESCRICAO");

            DataTable dt = auxSQL.retornaDataTable(sql.ToString());
            dgvSabores.DataSource = dt;
        }

        private bool validaCampos()
        {
            descricao = txtSabor.Text;
            if (string.IsNullOrEmpty(descricao))
                return false;

            if (cboTipo.SelectedIndex < 0)
                return false;

            tipo = cboTipo.SelectedItem.ToString();
            if (string.IsNullOrEmpty(tipo))
                return false;

            status = chkStatus.Checked ? 1 : 0;

            return true;
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            txtID.Enabled = false;
        }
        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void txtSaborFiltro_TextChanged(object sender, EventArgs e)
        {
            preencherCampos();
        }

        private void DgvAlertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvSabores["colID", e.RowIndex].Value.ToString());
            }
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {


            if (validaCampos())
            {
                if (clickBtns.Equals("Novo"))
                {
                    DialogResult result = MessageBox.Show("Deseja salvar o novo Sabor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            auxSQL.insertSabor(descricao, tipo, status);
                            preencherCampos();
                            MessageBox.Show("Sabor salvo com sucesso!", "Sabor Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (clickBtns.Equals("Editar"))
                {
                    DialogResult result = MessageBox.Show("Deseja salvar as alterações do Sabor - " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            auxSQL.updateSabor(id, descricao, tipo, status);
                            MessageBox.Show("Sabor alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            preencherCampos();
                        }

                    }
                }
            }
            else
                MessageBox.Show("Verifique as informações preenchidas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
            


         public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja editar o lembrete " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.No)
                {
                    toolStripVoltarJCS_Click(sender, e);

                    this.toolStripNovoJCS.Enabled = true;
                    this.toolStripEditarJCS.Enabled = true;
                    this.toolStripSalvarJCS.Enabled = false;
                    this.toolStripDeletarJCS.Enabled = false;
                    this.toolStripVoltarJCS.Enabled = false;
                    this.Text = nomeForm + " (Voltar)";
                    clickBtns = "Voltar";
                    botaoRetorno = true;
                }
                else
                {
                    DataTable dt = auxSQL.retornaDataTable("SELECT ID, DESCRICAO, TIPO, ATIVO FROM SABOR WHERE ID = " + id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtSabor.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    cboTipo.SelectedItem = dt.Rows[0]["TIPO"].ToString();
                    chkStatus.Checked = dt.Rows[0]["ATIVO"].ToString().Equals("True") ? true : false;
                    
                }

            }
        }
    }
}
