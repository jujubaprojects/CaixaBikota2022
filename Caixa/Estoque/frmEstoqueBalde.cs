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

namespace Caixa.Estoque
{
    public partial class frmEstoqueBalde : frmCadastroJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private int id = 0, qtDescricao = 0, qtDescricaoMax = 0;
        private string produto = "", nomeForm = "", descricao = "";
        private List<string> listaDesc, listaOrdernada;

        private DataTable dtProduto, dtSabor;

        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();

        public frmEstoqueBalde(string pNomeFormulario)
        {
            InitializeComponent();

            this.nomeForm = pNomeFormulario;

            preencherCampos();

            dtProduto = auxSQL.retornaDataTable("SELECT * FROM PRODUTO WHERE TIPO = 4");
            dtSabor = auxSQL.retornaDataTable("SELECT DESCRICAO FROM SABOR WHERE TIPO = 'POTES'");

            preencherCombo(dtProduto, cboProduto, 0);
            preencherCombo(dtSabor, cboSabor1, 0);
            preencherCombo(dtSabor, cboSabor2, 0);
            preencherCombo(dtSabor, cboSabor3, 0);
            preencherCombo(dtSabor, cboSabor4, 0);
            preencherCombo(dtSabor, cboSabor5, 0);
            preencherCombo(dtSabor, cboSabor6, 0);
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
        }

        private bool validaCampos()
        {
            if (cboProduto.SelectedIndex <= -1)
                return false;


            produto = cboProduto.SelectedItem.ToString();

            listaDesc = new List<string>();
            listaOrdernada = new List<string>();

            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            else
                return false;
            //auxDesc += cboDesc1.SelectedItem.ToString();
            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc2.SelectedItem.ToString();
            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc3.SelectedItem.ToString();
            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc4.SelectedItem.ToString();
            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc5.SelectedItem.ToString();
            if (cboSabor1.SelectedIndex > -1)
                listaDesc.Add(cboSabor1.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc6.SelectedItem.ToString();

            listaOrdernada = listaDesc.OrderBy(x => x).ToList();

            return true;
                   }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {

            if (clickBtns.Equals("Novo"))
            {
                if (validaCampos())
                {
                    DialogResult result = MessageBox.Show("Deseja salvar o novo Estoque de Potes?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            descricao = produto + ": ";
                            auxSQL.insertEstoquePote(int.Parse(dtProduto.Rows[cboProduto.SelectedIndex]["ID"].ToString()));

                            for (int i =0; i < listaOrdernada.Count; i++)
                            {
                                descricao += listaOrdernada[i] + ", ";
                                auxSQL.insertEstoquePoteSabor(listaOrdernada[i]);
                            }

                            descricao = descricao.Substring(0, descricao.Length - 2);
                            preencherCampos();
                        }
                    }
                }
                else
                    MessageBox.Show("Informe todos o Pote e o(s) Sabor(es)!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (clickBtns.Equals("Editar"))
            {
                validaCampos();
                DialogResult result = MessageBox.Show("Deseja salvar as alterações do Controle de Estoque de Potes do: " + descricao + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Controle de Estoque de Potes alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
            }


        }

        private void DgvLink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvEstPotes["colID", e.RowIndex].Value.ToString());
                descricao = dgvEstPotes["colDescricao", e.RowIndex].Value.ToString();
            }
        }

        private void CboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricaoMax = int.Parse(dtProduto.Rows[cboProduto.SelectedIndex]["QT_DESCRICAO"].ToString());
            qtDescricao = 0;

            if (qtDescricaoMax == -1)
                cboSabor1.Enabled = false;
            else
                cboSabor1.Enabled = true;


            cboSabor1.SelectedIndex = -1;
            cboSabor2.SelectedIndex = -1;
            cboSabor3.SelectedIndex = -1;
            cboSabor4.SelectedIndex = -1;
            cboSabor5.SelectedIndex = -1;
            cboSabor6.SelectedIndex = -1;
            cboSabor2.Enabled = false;
            cboSabor3.Enabled = false;
            cboSabor4.Enabled = false;
            cboSabor5.Enabled = false;
            cboSabor6.Enabled = false;
        }

        private void CboSabor6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboSabor6.SelectedIndex = -1;
                cboSabor6.Enabled = false;
                cboSabor5.Focus();
            }
        }

        private void CboSabor5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboSabor5.SelectedIndex = -1;
                cboSabor5.Enabled = false;
                cboSabor4.Focus();
            }
        }

        private void CboSabor4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboSabor4.SelectedIndex = -1;
                cboSabor4.Enabled = false;
                cboSabor3.Focus();
            }
        }

        private void CboSabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 1;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor2.Enabled = false;
                cboSabor2.SelectedIndex = -1;
            }
            else
                cboSabor2.Enabled = true;
        }

        private void CboSabor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 3;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor4.Enabled = false;
                cboSabor4.SelectedIndex = -1;
            }
            else
                cboSabor4.Enabled = true;
        }

        private void CboSabor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 4;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor5.Enabled = false;
                cboSabor5.SelectedIndex = -1;
            }
            else
                cboSabor5.Enabled = true;
        }

        private void CboSabor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 5;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor6.Enabled = false;
                cboSabor6.SelectedIndex = -1;
            }
            else
                cboSabor6.Enabled = true;
        }

        private void CboSabor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 6;
        }

        private void CboSabor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboSabor3.SelectedIndex = -1;
                cboSabor3.Enabled = false;
                cboSabor2.Focus();
            }
        }

        private void CboSabor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == '\b')
            {
                cboSabor2.SelectedIndex = -1;
                cboSabor2.Enabled = false;
                cboSabor1.Focus();
            }
        }

        private void CboSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtDescricao = 1;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor2.Enabled = false;
                cboSabor2.SelectedIndex = -1;
            }
            else
                cboSabor2.Enabled = true;
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
                    //txtID.Text = dt.Rows[0]["ID"].ToString();
                    //txtDescricao.Text = dt.Rows[0]["DESCRICAO"].ToString();
                    //txtQtEstoque.Text = dt.Rows[0]["QT_ESTOQUE"].ToString();
                    //txtQTEstIdeal.Text = dt.Rows[0]["QT_ESTOQUE_IDEAL"].ToString();
                    //chkAtivo.Checked = dt.Rows[0]["STATUS"].ToString().Equals("True") ? true : false;
                }

            }
        }

        private void preencherCampos(int pInicio = 0)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT EP.ID,P.DESCRICAO PRODUTO, dbo.RETORNA_SABORES(EP.ID) DESCRICAO, EP.DATA ");
            sql.Append("FROM ESTOQUE_POTE EP ");
            sql.Append("JOIN PRODUTO P ON(EP.PRODUTO = P.ID) ");
            sql.Append("ORDER BY PRODUTO, DESCRICAO ");
            dgvEstPotes.DataSource = auxSQL.retornaDataTable(sql.ToString());
            if (pInicio == 1 && dgvEstPotes.Rows.Count > 0)
            {
                id = int.Parse(dgvEstPotes["colID", 0].Value.ToString());
                descricao = dgvEstPotes["colDescricao", 0].Value.ToString();
            }
        }

        private void preencherCombo(DataTable pDTable, ComboBox pCombo, int pOcultar)
        {

            if (pOcultar == 1 || pDTable.Rows.Count == 0)
            {
                pCombo.Visible = false;
            }
            {
                pCombo.Items.Clear();
                pCombo.Visible = true;
                for (int i = 0; i < pDTable.Rows.Count; i++)
                {
                    pCombo.Items.Add(pDTable.Rows[i]["descricao"]);
                }
            }
        }
    }
}
