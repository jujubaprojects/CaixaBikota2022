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

namespace Caixa.Reports
{
    public partial class frmRelVendas : FormJCS
    {
        SQL.SQL auxSQL = new SQL.SQL();
        private string produtoPai = "", produtoFilho = "", descricao = "";
        private int situacao = -1;


        public frmRelVendas()
        {
            InitializeComponent();

            preencherCampos();
        }

        private void validaCampos()
        {
            if (cboProdutoFilho.SelectedIndex > 0)
            {
                produtoFilho = cboProdutoFilho.SelectedItem.ToString();
            }

            if (cboProdutoPai.SelectedIndex > 0)
            {
                produtoPai = cboProdutoPai.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(txtDescricao.Text))
            {
                descricao = txtDescricao.Text;
            }

            if (cboSituacao.SelectedIndex > 0)
            {
                situacao = cboSituacao.SelectedIndex-1;
                if (cboSituacao.SelectedIndex == 5)
                    situacao = 8;
            }
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            validaCampos();

            DataTable dt = auxSQL.relVendas(situacao, produtoPai, produtoFilho, descricao, dtpDataInicial.Value, dtpDataFinal.Value);
            frmRelatorio frm = new frmRelatorio(dt, "relVendas.rdlc", "dsRel", "frmRelVendas");
            frm.ShowDialog();
        }

        private void preencherCampos()
        {
            preencherCombo(auxSQL.retornaDataTable("SELECT 'TODOS' DESCRICAO UNION ALL SELECT DESCRICAO FROM CATEGORIA"), cboProdutoPai);

        }

        private void preencherCombo(DataTable pDTable, ComboBox pCombo)
        {
            pCombo.Items.Clear();
            for (int i = 0; i < pDTable.Rows.Count; i++)
            {
                pCombo.Items.Add(pDTable.Rows[i]["descricao"]);
            }
        }

        private void CboProdutoPai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdutoPai.SelectedIndex > 0)
            {
                preencherCombo(auxSQL.retornaDataTable("SELECT 'TODOS' DESCRICAO UNION ALL SELECT DESCRICAO FROM PRODUTO WHERE TIPO = (SELECT TIPO FROM PRODUTO_PAI WHERE DESCRICAO = '"+cboProdutoPai.SelectedItem+"')"), cboProdutoFilho);
           }
            else
            {
                cboProdutoFilho.Items.Clear();
            }
        }
    }
}
