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
        private double qtPotes = 0;
        private string produto = "", nomeForm = "", descricao = "", sabores = "";
        private List<string> listaDesc, listaOrdernada;

        private DataTable dtProduto, dtSabor;

        ToolStripButton btnVoltar = new ToolStripButton();
        ToolStripButton btnEditar = new ToolStripButton();
        ToolStripButton btnDeletar = new ToolStripButton();
        ToolStripButton btnSalvar = new ToolStripButton();
        ToolStripButton btnNovo = new ToolStripButton();

        public frmEstoqueBalde(string pNomeFormulario)
        {
            btnNovo = toolStripNovoJCS ;
            btnVoltar = toolStripVoltarJCS;
            btnEditar = toolStripEditarJCS;
            btnDeletar = toolStripDeletarJCS;
            btnSalvar = toolStripSalvarJCS;

            InitializeComponent();

            this.nomeFormulario = pNomeFormulario;
            this.Text = pNomeFormulario;

            preencherCampos();

            dtProduto = auxSQL.retornaDataTable("SELECT * FROM PRODUTO WHERE TIPO = 4");
            dtSabor = auxSQL.retornaDataTable("SELECT DESCRICAO FROM SABOR WHERE TIPO = 'POTES' ORDER BY 1");

            preencherCombo(dtProduto, cboProduto, 0);
            preencherCombo(dtSabor, cboSabor1, 0);
            preencherCombo(dtSabor, cboSabor2, 0);
            preencherCombo(dtSabor, cboSabor3, 0);
            preencherCombo(dtSabor, cboSabor4, 0);
            preencherCombo(dtSabor, cboSabor5, 0);
            preencherCombo(dtSabor, cboSabor6, 0);


            btnDeletar.Click += new EventHandler(toolStripDeletarJCS_Click);
            btnSalvar.Click += new EventHandler(toolStripSalvarJCS_Click);
            btnEditar.Click += new EventHandler(toolStripEditarJCS_Click);
            btnVoltar.Click += new EventHandler(toolStripVoltarJCS_Click);
            btnNovo.Click += new EventHandler(toolStripNovoJCS_Click);
            

            desabilitarTudo();
        }

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            limpar(this);
        }
        public void toolStripNovoJCS_Click(object sender, EventArgs e)
        {
            habilitarTudo();
        }

        private void desabilitarTudo ()
        {
            this.cboProduto.Enabled = false;
            this.cboSabor1.Enabled = false;
            this.txtQT.Enabled = false;
        }

        private void habilitarTudo ()
        {
            this.cboProduto.Enabled = true;
            this.cboSabor1.Enabled = true;
            this.txtQT.Enabled = true;
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
            if (cboSabor2.SelectedIndex > -1)
                listaDesc.Add(cboSabor2.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc2.SelectedItem.ToString();
            if (cboSabor3.SelectedIndex > -1)
                listaDesc.Add(cboSabor3.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc3.SelectedItem.ToString();
            if (cboSabor4.SelectedIndex > -1)
                listaDesc.Add(cboSabor4.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc4.SelectedItem.ToString();
            if (cboSabor5.SelectedIndex > -1)
                listaDesc.Add(cboSabor5.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc5.SelectedItem.ToString();
            if (cboSabor6.SelectedIndex > -1)
                listaDesc.Add(cboSabor6.SelectedItem.ToString());
            //auxDesc += ", " + cboDesc6.SelectedItem.ToString();

            listaOrdernada = listaDesc.OrderBy(x => x).ToList();
            sabores = listaOrdernada[0] + ";";
            for (int i = 1; i < listaOrdernada.Count; i++)
                sabores += " " + listaOrdernada[i] + ";";


            if (!string.IsNullOrEmpty(txtQT.Text) && double.Parse(txtQT.Text) > 0)
                qtPotes = double.Parse(txtQT.Text);
            else
                return false;

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
                            DataTable dtAux = auxSQL.buscaEstoquePoteSabor(int.Parse(dtProduto.Rows[cboProduto.SelectedIndex]["ID"].ToString()), sabores);
                            if (dtAux.Rows.Count == 0)
                            {
                                descricao = produto + ": ";
                                auxSQL.insertEstoquePote(int.Parse(dtProduto.Rows[cboProduto.SelectedIndex]["ID"].ToString()), qtPotes);

                                for (int i = 0; i < listaOrdernada.Count; i++)
                                {
                                    descricao += listaOrdernada[i] + ", ";
                                    auxSQL.insertEstoquePoteSaborUltimoRegistro(listaOrdernada[i]);
                                }

                                descricao = descricao.Substring(0, descricao.Length - 2);
                            }
                            else
                            {
                                auxSQL.updateAddEstoquePote(int.Parse(dtAux.Rows[0]["ID"].ToString()), qtPotes);
                            }
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
                        auxSQL.updateEstoquePote(id, int.Parse(dtProduto.Rows[cboProduto.SelectedIndex]["ID"].ToString()), qtPotes);
                        auxSQL.deleteEstoquePoteSabor(id);
                        for (int i = 0; i < listaOrdernada.Count; i++)
                        {
                            descricao += listaOrdernada[i] + ", ";
                            auxSQL.insertEstoquePoteSabor(id, listaOrdernada[i]);
                        }
                        MessageBox.Show("Controle de Estoque de Potes alterado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        preencherCampos();
                    }
                }
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
            qtDescricao = 2;
            if (qtDescricao == qtDescricaoMax)
            {
                cboSabor2.Enabled = false;
                cboSabor2.SelectedIndex = -1;
            }
            else
                cboSabor3.Enabled = true;
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

        private void DgvEstPotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(dgvEstPotes["colID", e.RowIndex].Value.ToString());
                produto = dgvEstPotes["colProduto", e.RowIndex].Value.ToString();
                qtPotes = double.Parse(dgvEstPotes["colQt", e.RowIndex].Value.ToString());
                sabores = dgvEstPotes["colDescricao", e.RowIndex].Value.ToString();
                descricao = dgvEstPotes["colDescricao", e.RowIndex].Value.ToString(); 
            }
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

                    habilitarTudo();

                    //DataTable dt = auxSQL.buscaControleEstoque(id);
                    txtQT.Text = qtPotes.ToString();
                    cboProduto.SelectedItem = produto;

                    string[] arraySabores = sabores.Split(';');
                    
                    if (arraySabores.Length == 6)
                    {

                        cboSabor1.SelectedItem = arraySabores[0];
                        cboSabor2.SelectedItem = arraySabores[1].Substring(1);
                        cboSabor3.SelectedItem = arraySabores[2].Substring(1);
                        cboSabor4.SelectedItem = arraySabores[3].Substring(1);
                        cboSabor5.SelectedItem = arraySabores[4].Substring(1);
                    }
                    else if (arraySabores.Length == 5)
                    {
                        cboSabor1.SelectedItem = arraySabores[0];
                        cboSabor2.SelectedItem = arraySabores[1].Substring(1);
                        cboSabor3.SelectedItem = arraySabores[2].Substring(1);
                        cboSabor4.SelectedItem = arraySabores[3].Substring(1);
                        cboSabor5.SelectedItem = arraySabores[4].Substring(1);

                    }
                    else if (arraySabores.Length == 4)
                    {
                        cboSabor1.SelectedItem = arraySabores[0];
                        cboSabor2.SelectedItem = arraySabores[1].Substring(1);
                        cboSabor3.SelectedItem = arraySabores[2].Substring(1);
                        cboSabor4.SelectedItem = arraySabores[3].Substring(1);
                    }
                    else if (arraySabores.Length == 3)
                    {
                        cboSabor1.SelectedItem = arraySabores[0];
                        cboSabor2.SelectedItem = arraySabores[1].Substring(1);
                        cboSabor3.SelectedItem = arraySabores[2].Substring(1);
                    }
                    else if (arraySabores.Length == 2)
                    {
                        cboSabor1.SelectedItem = arraySabores[0];
                        cboSabor2.SelectedItem = arraySabores[1].Substring(1);
                    }
                    else
                    {
                        cboSabor1.SelectedItem = arraySabores[0];                        
                    }
                }

            }
        }

        private void preencherCampos(int pInicio = 0)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT EP.ID,P.DESCRICAO PRODUTO, dbo.RETORNA_SABORES(EP.ID) DESCRICAO, EP.QT_EST QT, EP.DATA ");
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
