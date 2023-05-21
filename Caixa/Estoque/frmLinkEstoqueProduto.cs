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

namespace Caixa.Estoque
{
    public partial class frmLinkEstoqueProduto : frmCadastroJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private int id = 0, qtEstoque = 0, qtEstIdeal = 0;
        private bool status = true;
        private string descricao = "", nomeForm = "";
        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        public frmLinkEstoqueProduto()
        {
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

            InitializeComponent();
            nomeForm = this.Text;
            preencherCampos(1);

        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
            chkAtivo.Checked = true;
            txtID.Enabled = false;
        }

        private void validaCampos()
        {
            descricao = txtDescricao.Text;
            qtEstoque = int.Parse(txtQtEstoque.Text);
            qtEstIdeal = int.Parse(txtQTEstIdeal.Text);
            status = chkAtivo.Checked;
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {

            if (clickBtns.Equals("Novo"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar o novo Controle de Estoque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.insertControleEstoque(descricao, qtEstoque, qtEstIdeal, status);
                        preencherCampos();
                    }
                }
            }
            else if (clickBtns.Equals("Editar"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as alterações do Controle de Estoque " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        auxSQL.updateControleEstoque(id, descricao, qtEstoque, qtEstIdeal, status);
                        MessageBox.Show("Controle de Estoque alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
            }


        }

        private void DgvLink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvLink["colID", e.RowIndex].Value.ToString());
                descricao = dgvLink["colDescricao", e.RowIndex].Value.ToString();
            }
        }

        public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja editar o Controle de Estoque " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    DataTable dt = auxSQL.buscaControleEstoque(id);
                    txtID.Text = dt.Rows[0]["ID"].ToString();
                    txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    txtQtEstoque.Text = dt.Rows[0]["QT_ESTOQUE"].ToString();
                    txtQTEstIdeal.Text = dt.Rows[0]["QT_ESTOQUE_IDEAL"].ToString();
                    chkAtivo.Checked= dt.Rows[0]["STATUS"].ToString().Equals("True") ? true : false;
                }

            }
        }

        private void preencherCampos(int pInicio = 0)
        {
            StringBuilder sql = new StringBuilder();
            //sql.Append("SELECT SE.ID, P.DESCRICAO AS PRODUTO, CONCAT(CE.PRODUTO, ' - ', CE.DESCRICAO) AS MATERIA_PRIMA, QT_SUB ");
            //sql.Append("FROM PRODUTO P ");
            //sql.Append("JOIN SUB_ESTOQUE SE ON(P.ID = SE.PRODUTO) ");
            //sql.Append("JOIN CONTROLE_ESTOQUE CE ON(CE.ID = SE.CONTROLE_ESTOQUE) ORDER BY PRODUTO ");
            sql.Append("SELECT ID, DESCRICAO, QT_ESTOQUE, QT_ESTOQUE_IDEAL, STATUS FROM CONTROLE_ESTOQUE");
            dgvLink.DataSource = auxSQL.retornaDataTable(sql.ToString());
            if (pInicio == 1 && dgvLink.Rows.Count > 0)
            {
                id = int.Parse(dgvLink["colID", 0].Value.ToString());
                descricao = dgvLink["colDescricao", 0].Value.ToString();
            }

        }
    }
}
