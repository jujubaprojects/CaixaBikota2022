﻿using Componentes;
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
    public partial class frmRelPedidoFornecedor : FormJCS

    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private DataTable dtGrid = new DataTable();
        public frmRelPedidoFornecedor()
        {
            InitializeComponent();
        }

        private void FrmRelPedidoFornecedor_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgvInformacao.ColumnCount; i++)
            //    dtGrid.Columns.Add(dgvInformacao.Columns[i].DataPropertyName);

            //preencherGrid();
            DataTable dtCombo = auxSQL.retornaDataTable("SELECT NOME FROM FORNECEDOR");
            cboFornecedor.Items.Add("TODOS OS FORNECEDORES");
            for (int i = 0; i < dtCombo.Rows.Count; i++)
                cboFornecedor.Items.Add(dtCombo.Rows[i]["NOME"].ToString());

            cboFornecedor.SelectedIndex = 0;
        }

        //private void CboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    preencherGrid();
        //}

        //private void preencherGrid()
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("SELECT DISTINCT CE.ID, CE.DESCRICAO DESC_ESTOQUE, CE.QT_ESTOQUE AS QT_EST, CE.QT_ESTOQUE_IDEAL AS EST_IDEAL, VERIFICAR_EST AS VERIFICAR ");
        //    sql.Append("FROM CONTROLE_ESTOQUE CE ");
        //    sql.Append("JOIN NFPROD_CONTROLESTQ NFPCE ON(NFPCE.COD_CONTRESTQ = CE.ID) ");
        //    sql.Append("JOIN NF_PROD NFP ON(NFP.COD_PROD = NFPCE.COD_PROD_NF) ");
        //    sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
        //    sql.Append("JOIN fornecedor F ON(F.id = NF.FORNECEDOR) ");
        //    sql.Append("WHERE ((CE.VERIFICAR_EST = 1 AND CE.QT_ESTOQUE <= CE.QT_ESTOQUE_IDEAL) OR (CE.QT_ESTOQUE < CE.QT_ESTOQUE_IDEAL))  AND CE.STATUS = 1 ");
        //    if (cboFornecedor.SelectedIndex > 0)
        //        sql.Append(" AND F.NOME LIKE '" + cboFornecedor.SelectedItem + "' ");
        //    sql.Append("ORDER BY DESC_ESTOQUE ");
        //    DataTable dtEstoque = auxSQL.retornaDataTable(sql.ToString());
        //    DataTable dtFinal;
        //    string historico = "";
        //    DataTable dtHistorico;

        //    DataRow row;
        //    dtGrid.Clear();

        //    for (int i = 0; i < dtEstoque.Rows.Count; i++)
        //    {
        //        row = dtGrid.NewRow();
        //        row["ID"] = dtEstoque.Rows[i]["ID"];
        //        row["DESC_ESTOQUE"] = dtEstoque.Rows[i]["DESC_ESTOQUE"];
        //        row["QT_EST"] = dtEstoque.Rows[i]["QT_EST"];
        //        row["EST_IDEAL"] = dtEstoque.Rows[i]["EST_IDEAL"];
        //        row["VERIFICAR"] = dtEstoque.Rows[i]["VERIFICAR"];

        //        sql.Clear();
        //        sql.Append("SELECT TOP 4 CE.ID, CE.DESCRICAO, CONCAT('Data: ' ,convert(varchar, NF.DT_ENTREGA, 103), ' - VL UNIT: R$', NFP.VL_UNIT , ' - ' , F.NOME_FANTASIA) INFORMACAO ");
        //        sql.Append("FROM CONTROLE_ESTOQUE CE ");
        //        sql.Append("JOIN NFPROD_CONTROLESTQ NFPCE ON(NFPCE.COD_CONTRESTQ = CE.ID) ");
        //        sql.Append("JOIN NF_PROD NFP ON(NFP.COD_PROD = NFPCE.COD_PROD_NF) ");
        //        sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
        //        sql.Append("JOIN fornecedor F ON(F.id = NF.FORNECEDOR) ");
        //        sql.Append("WHERE CE.ID = " + dtEstoque.Rows[i]["ID"].ToString() + " ");
        //        sql.Append("ORDER BY NF.DT_ENTREGA DESC ");
        //        dtHistorico = auxSQL.retornaDataTable(sql.ToString());
        //        historico = "";
        //        for (int j = 0; j < dtHistorico.Rows.Count; j++)
        //            historico += dtHistorico.Rows[j]["INFORMACAO"].ToString() + "\n";
        //        row["HISTORICO"] = historico;
        //        dtGrid.Rows.Add(row);

        //        dgvInformacao.DataSource = dtGrid;
        //    }

        //}

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            //sql.Append("SELECT CE.ID ID_EST, NF.id ID_NF, CE.DESCRICAO DESC_ESTOQUE, CE.QT_ESTOQUE AS QT_EST, CE.QT_ESTOQUE_IDEAL AS EST_IDEAL, CE.QT_ESTOQUE_IDEAL -  CE.QT_ESTOQUE QT_COMPRAR ,   ");
            //sql.Append("CASE WHEN(CE.VERIFICAR_EST = 1 AND CE.QT_ESTOQUE >= CE.QT_ESTOQUE_IDEAL) THEN 'Verificar Estoque' ");
            //sql.Append("WHEN(CE.QT_ESTOQUE < CE.QT_ESTOQUE_IDEAL) THEN 'Comprar' ");
            //sql.Append("ELSE 'Erro' END AS VERIFICAR, ");
            //sql.Append("CONCAT('Data: ', convert(varchar, NF.DT_ENTREGA, 103), ' - VL UNIT: R$', NFP.VL_UNIT, ' - ', F.NOME_FANTASIA) INFORMACAO ");
            //sql.Append("FROM CONTROLE_ESTOQUE CE ");
            //sql.Append("JOIN NFPROD_CONTROLESTQ NFPCE ON(NFPCE.COD_CONTRESTQ = CE.ID) ");
            //sql.Append("JOIN NF_PROD NFP ON(NFP.COD_PROD = NFPCE.COD_PROD_NF) ");
            //sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
            //sql.Append("JOIN fornecedor F ON (F.id = NF.FORNECEDOR AND NFPCE.FOR_ID = F.ID) ");
            //sql.Append("WHERE ((CE.VERIFICAR_EST = 1 AND CE.QT_ESTOQUE <= CE.QT_ESTOQUE_IDEAL) OR (CE.QT_ESTOQUE < CE.QT_ESTOQUE_IDEAL))  AND CE.STATUS = 1 ");
            //sql.Append("SELECT CE.ID ID_EST, NF.id ID_NF, CE.DESCRICAO DESC_ESTOQUE, CE.QT_ESTOQUE AS QT_EST, CE.QT_ESTOQUE_IDEAL AS EST_IDEAL, CE.QT_ESTOQUE_IDEAL -  CE.QT_ESTOQUE QT_COMPRAR , CE.OBSERVACAO, ");
            //sql.Append("CONCAT('Data: ', convert(varchar, NF.DT_ENTREGA, 103), ' - VL UNIT: R$', NFP.VL_UNIT, ' - ', F.NOME_FANTASIA) INFORMACAO ");
            //sql.Append("FROM CONTROLE_ESTOQUE CE ");
            //sql.Append("JOIN NFPROD_CONTROLESTQ NFPCE ON(NFPCE.COD_CONTRESTQ = CE.ID) ");
            //sql.Append("JOIN NF_PROD NFP ON(NFP.COD_PROD = NFPCE.COD_PROD_NF) ");
            //sql.Append("JOIN NF ON(NF.id = NFP.NF) JOIN fornecedor F ON(F.id = NF.FORNECEDOR AND NFPCE.FOR_ID = F.ID) ");
            //sql.Append("WHERE(CE.QT_ESTOQUE <= CE.QT_ESTOQUE_IDEAL) ");
            //sql.Append("AND CE.STATUS = 1 ");

            sql.Append("SELECT CE.ID ID_EST, NF.id ID_NF, CE.DESCRICAO DESC_ESTOQUE, CE.QT_ESTOQUE AS QT_EST, CE.QT_ESTOQUE_IDEAL, CE.QT_ESTOQUE_IDEAL - CE.QT_ESTOQUE QT_COMPRAR , CE.OBSERVACAO ");
            sql.Append("FROM CONTROLE_ESTOQUE CE ");
            sql.Append("JOIN NFPROD_CONTROLESTQ NFPCE ON(NFPCE.COD_CONTRESTQ = CE.ID) ");
            sql.Append("JOIN NF_PROD NFP ON(NFP.COD_PROD = NFPCE.COD_PROD_NF) ");
            sql.Append("JOIN NF ON(NF.id = NFP.NF) ");
            sql.Append("JOIN fornecedor F ON(F.id = NF.FORNECEDOR AND NFPCE.FOR_ID = F.ID) ");
            sql.Append("WHERE CE.STATUS = 1 AND (CE.PEDIDO_COMPRA = 1 OR (CE.QT_ESTOQUE < CE.QT_ESTOQUE_IDEAL)) ");
            if (cboFornecedor.SelectedIndex > 0)
                sql.Append("AND CE.ID IN (SELECT A.COD_CONTRESTQ FROM NFPROD_CONTROLESTQ A WHERE A.FOR_ID = (SELECT ID FROM FORNECEDOR WHERE NOME LIKE '" + cboFornecedor.SelectedItem + "'))");
            sql.Append("ORDER BY CE.DESCRICAO ASC, NF.DT_ENTREGA DESC ");

            DataTable dt = auxSQL.retornaDataTable(sql.ToString());
            //frmRelatorio frm = new frmRelatorio(dt, "relPedidoFornecedor.rdlc", "dsRel", "frmRelPedidoFornecedor");
            frmRelatorio frm = new frmRelatorio(dt, "relPedidoCompraSimples.rdlc", "dsRel", "frmRelPedidoFornecedor");
            frm.ShowDialog();
        }
    }
}