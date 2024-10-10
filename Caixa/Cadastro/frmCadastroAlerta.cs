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
    public partial class frmCadastroAlerta : frmCadastroJCS
    {
        private int id, status;
        private string descricao, nomeForm;

        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();
        public frmCadastroAlerta()
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
        }

        private void preencherCampos()
        {
            DataTable dt = auxSQL.retornaDataTable("SELECT ID, DESCRICAO, STATUS FROM ALERTA ORDER BY ID");
            dgvAlertas.DataSource = dt;
        }

        private bool validaCampos()
        {
            descricao = txtDescricao.Text;
            if (string.IsNullOrEmpty(descricao))
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

        private void DgvAlertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvAlertas["colID", e.RowIndex].Value.ToString());
            }
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {


            if (validaCampos())
            {
                if (clickBtns.Equals("Novo"))
                {
                    DialogResult result = MessageBox.Show("Deseja salvar o novo lembrete?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            auxSQL.insertAlerta(descricao, status);
                            preencherCampos();
                        }
                    }
                }
                else if (clickBtns.Equals("Editar"))
                {
                    DialogResult result = MessageBox.Show("Deseja salvar as alterações do Alerta - " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            auxSQL.updateAlerta(id, descricao, status);
                            MessageBox.Show("Alerta alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    DataTable dt = auxSQL.retornaDataTable("SELECT ID, DESCRICAO, STATUS FROM ALERTA WHERE ID = " + id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    chkStatus.Checked = dt.Rows[0]["STATUS"].ToString().Equals("True") ? true : false;
                    
                }

            }
        }
    }
}
