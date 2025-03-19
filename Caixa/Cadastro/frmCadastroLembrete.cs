using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componentes;

namespace Caixa.Cadastro
{
    //REPETIRO : 1 = DIARIAMENTE / 2 = SEMANALMENTE / 3 = QUINZENALMENTE / 4 = MENSALMENTE / 9 = UNICA VEZ
    public partial class frmCadastroLembrete : frmCadastroJCS
    {
        private int id, repetir, status;
        private string descricao, nomeForm;
        private DateTime data;

        private SQL.SQL auxSQL = new SQL.SQL();
        //ToolStripButton btnNovo = new ToolStripButton();
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();
        public frmCadastroLembrete()
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


            cboRepetir.Items.Add("UNICA VEZ");//9
            cboRepetir.Items.Add("DIARIAMENTE");//1
            cboRepetir.Items.Add("SEMANALMENTE");//2
            cboRepetir.Items.Add("QUINZENALMENTE");//3
            cboRepetir.Items.Add("MENSALMENTE");//4
            cboRepetir.Items.Add("ANUALMENTE"); //5


            cboStatus.Items.Add("INATIVO");//0
            cboStatus.Items.Add("ATIVO");//1


            preencherCampos();

        }



        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            cboRepetir.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void validaCampos()
        {
            descricao = txtDescricao.Text;
            if (cboRepetir.SelectedIndex == 0)
                repetir = 9;
            else
                repetir = cboRepetir.SelectedIndex;

            status = cboStatus.SelectedIndex;
            data = dtpData.Value;
        }
        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {

        }

        private void DgvLembretes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvLembretes["colID", e.RowIndex].Value.ToString());
            }
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {

            if (clickBtns.Equals("Novo"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar o novo lembrete?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertLembrete(descricao, data, repetir, status);
                        preencherCampos();
                    }
                }
            }
            else if (clickBtns.Equals("Editar"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as alterações do Lembrete - " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.updateLembrete(id, descricao, data, repetir, status);
                        MessageBox.Show("Lembrete alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
            }


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
                    DataTable dt = auxSQL.retornaDataTable("SELECT * FROM LEMBRETE WHERE ID = " + id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    dtpData.Value = DateTime.Parse(dt.Rows[0]["DATA"].ToString());
                    cboStatus.SelectedIndex = dt.Rows[0]["STATUS"].ToString().Equals("True") ? 1 : 0;
                    if (dt.Rows[0]["REPETIR"].ToString().Equals("9"))
                        cboRepetir.SelectedIndex = 0;
                    else
                        cboRepetir.SelectedIndex = int.Parse(dt.Rows[0]["REPETIR"].ToString());
                }

            }
        }

        private void preencherCampos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, DATA, ");
            sql.Append("CASE REPETIR ");
            sql.Append("WHEN 9 THEN 'UNICA VEZ' ");
            sql.Append("WHEN 1 THEN 'DIARIAMENTE' ");
            sql.Append("WHEN 2 THEN 'SEMANALMENTE' ");
            sql.Append("WHEN 3 THEN 'QUINZENALMENTE' ");
            sql.Append("WHEN 4 THEN 'MENSALMENTE' ");
            sql.Append("WHEN 5 THEN 'ANUALMENTE' ");
            sql.Append("ELSE 'ERRO' END REPETIR, ");
            sql.Append("CASE STATUS WHEN 0 THEN 'INATIVO' ELSE 'ATIVO' END STATUS ");
            sql.Append("FROM LEMBRETE ");
            sql.Append("ORDER BY DESCRICAO ");

            dgvLembretes.DataSource = auxSQL.retornaDataTable(sql.ToString());

        }

    }
}
