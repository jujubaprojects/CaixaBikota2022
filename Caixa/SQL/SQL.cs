using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.SQL
{
    class SQL
    {
        private dal.Conexao conexao = new dal.Conexao();


        private SqlConnection retornaConexao()
        {
            return new dal.Conexao().retornaConexao();
        }

        private string queryBuscaTipoPedido(int pID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO FROM TIPO_PEDIDO ");

            if (pID > 0)
                sql.Append("WHERE ID = " + pID);

            return sql.ToString();
        }
        public DataTable buscaTipoPedido(int pID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = conexao.retornaConexao();

            string sql = "SELECT ID, DESCRICAO FROM TIPO_PEDIDO ";

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;

            if (pID > 0)
            {
                sql += "WHERE ID = @pID ";

                sqlc = null;
                sqlc = new SqlCommand(sql);
                sqlc.Parameters.AddWithValue("@pID", pID);
                sqlc.CommandType = CommandType.Text;
            }

            dt = conexao.executarSelect(sqlc, conn);

            return dt;
        }
        public DataTable buscaPedidos(int pSituacao, int pTipo, string pData)
        {
            string sql = queryBuscaPedidos(pSituacao, pTipo, pData);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pTipo", pTipo);
            sqlc.Parameters.AddWithValue("@pData", pData);

            return conexao.executarSelect(sqlc, conn);
        }

        public string queryBuscaPedidos(int pSituacao, int pTipo, string pData)
        {
            StringBuilder sql = new StringBuilder();

            //sql.Append("SELECT TAB.PEDIDO ID, TAB.DESCRICAO, TAB.HORA, SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) VL_TOTAL,  ");
            //sql.Append("SUM(COALESCE(PG.VL_PAGO, 0)) VL_PAGO, SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) - SUM(COALESCE(PG.VL_PAGO, 0)) VL_ABERTO ");
            //sql.Append("FROM ( ");
            //sql.Append("SELECT PED.ID PEDIDO, PP.ID PED_PROD_ID, PED.MESA DESCRICAO, PP.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, P.VALOR AS VL_PRODUTO, PP.QT_PRODUTO ");
            //sql.Append("FROM PEDIDO PED ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            //sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            //if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
            //    sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) AND PED.TIPO = @pTipo ");
            //else
            //    sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) AND PED.TIPO = @pTipo ");
            //sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData ");
            //sql.Append("UNION ALL ");
            //sql.Append("SELECT PED.ID, PED_ADD.PEDIDO_PRODUTO PED_PROD_ID, PED.MESA DESCRICAO, PED_ADD.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, P2.VALOR VL_PRODUTO, PED_ADD.QT_PRODUTO ");
            //sql.Append("FROM PEDIDO PED ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            //sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO_ADDS PED_ADD ON(PP.ID = PED_ADD.PEDIDO_PRODUTO) ");
            //sql.Append("LEFT JOIN PRODUTO P2 ON(PED_ADD.PRODUTO = P2.ID) ");
            //if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
            //    sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) AND PED.TIPO = @pTipo ");
            //else
            //    sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) AND PED.TIPO = @pTipo ");
            //sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData) TAB ");
            //sql.Append("LEFT JOIN ");
            //sql.Append("(SELECT PEDIDO_PRODUTO, SUM(VL_PAGO) VL_PAGO FROM PAGAMENTO GROUP BY PEDIDO_PRODUTO) PG ON(TAB.PED_PROD_ID = PG.PEDIDO_PRODUTO) ");
            //sql.Append("GROUP BY TAB.PEDIDO, TAB.DESCRICAO, TAB.HORA ");

            sql.Append("SELECT AUX.ID, AUX.DESCRICAO, AUX.HORA, SUM(AUX.VL_TOTAL) VL_TOTAL, SUM(AUX.VL_PAGO) VL_PAGO, SUM(AUX.VL_TOTAL) - SUM(AUX.VL_PAGO) AS VL_ABERTO  ");
            sql.Append("FROM ");
            sql.Append("(SELECT TAB.PEDIDO ID, TAB.DESCRICAO, TAB.HORA, SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) VL_TOTAL, SUM(COALESCE(TAB.VL_PAGO, 0)) VL_PAGO ");
            //sql.Append("CASE WHEN SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) - SUM(COALESCE(PG.VL_PAGO, 0)) < 0 THEN 0 ELSE SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) - SUM(COALESCE(PG.VL_PAGO, 0)) END VL_ABERTO ");
            sql.Append("FROM( ");
            sql.Append("SELECT DISTINCT PED.ID PEDIDO, PP.ID PED_PROD_ID, CONCAT(PED.DESCRICAO, ' ', PED.ENDERECO) AS DESCRICAO, PP.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, CASE PP.SITUACAO WHEN 0 THEN 0 ELSE P.VALOR END AS VL_PRODUTO, PP.QT_PRODUTO, SUM(PG.VL_PAGO) VL_PAGO  ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PAGAMENTO PG ON (PG.PEDIDO_PRODUTO = PP.ID) ");
            if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
            {
                //sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) ");
                sql.Append("WHERE  PED.SITUACAO IN (1,2,3) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");
            }
            else
            {
                sql.Append("WHERE PED.SITUACAO IN (@pSituacao) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");

            }
            if (!string.IsNullOrEmpty(pData))
                sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData ");
            else
                sql.Append(" AND DT_INICIAL - 7 < GETDATE() ");

            //sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO ");
            sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PED.ENDERECO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO, PP.SITUACAO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT PED.ID, PED_ADD.PEDIDO_PRODUTO PED_PROD_ID, CONCAT(PED.DESCRICAO, ' ', PED.ENDERECO) AS DESCRICAO, PED_ADD.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA,  ");
            sql.Append("CASE WHEN PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO /* PP.QT_PRODUTO*/ * P2.VALOR ELSE PP.QT_PRODUTO* P2.VALOR END VL_PRODUTO, ");
            sql.Append("PP.QT_PRODUTO, 0 VL_PAGO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO_ADDS PED_ADD ON(PP.ID = PED_ADD.PEDIDO_PRODUTO) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(PED_ADD.PRODUTO = P2.ID) ");
            if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
            {
                sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");
            }
            else
            {
                sql.Append("WHERE PED.SITUACAO IN (@pSituacao) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");
            }
            if (!string.IsNullOrEmpty(pData))
                sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData ");
            else
                sql.Append(" AND DT_INICIAL - 7 < GETDATE() ");
            sql.Append(") TAB ");
            sql.Append("GROUP BY TAB.PEDIDO, TAB.DESCRICAO, TAB.HORA, TAB.VL_PAGO ");
            sql.Append(") AUX ");
            sql.Append("GROUP BY ID, DESCRICAO, HORA ");


            return sql.ToString();

        }

        public void alteraSituacaoPedProdPago ()
        {
            SqlConnection conn = conexao.retornaConexao();

            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO_PRODUTO SET SITUACAO = 3 ");
            sql.Append("WHERE ID IN(SELECT PED_PROD ");
            sql.Append("FROM( ");
            sql.Append("SELECT TAB.PEDIDO ID, TAB.PED_PROD, ");
            sql.Append("SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) VL_TOTAL, SUM(COALESCE(TAB.VL_PAGO, 0)) VL_PAGO ");
            sql.Append("FROM( ");
            sql.Append("SELECT DISTINCT PED.ID PEDIDO, PP.ID AS PED_PROD, P.VALOR AS VL_PRODUTO, PP.QT_PRODUTO, SUM(PG.VL_PAGO) VL_PAGO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN(1, 2, 3, 4)  AND PP.SITUACAO != 3 AND PED.DT_INICIAL-7 <= getdate() ");
            sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT PED.ID, PP.ID AS PED_PROD, P2.VALOR VL_PRODUTO, PP.QT_PRODUTO, 0 VL_PAGO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO_ADDS PED_ADD ON(PP.ID = PED_ADD.PEDIDO_PRODUTO) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(PED_ADD.PRODUTO = P2.ID) ");
            sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN(1, 2, 3, 4) AND PP.SITUACAO != 3 AND PED.DT_INICIAL-7 <=  getdate() ");
            sql.Append(") TAB ");
            sql.Append("GROUP BY TAB.PEDIDO, TAB.PED_PROD ");
            sql.Append(") A ");
            sql.Append("WHERE A.VL_TOTAL = A.VL_PAGO) AND SITUACAO = 2 ");

            SqlCommand sqlc = new SqlCommand(sql.ToString());
            sqlc.CommandType = CommandType.Text;

            conexao.executarInsUpDel(sqlc, conn);
        }


        public void insertPagamento(int pID, double pValor, int pTipoPagamento)
        {
            string sql = queryInsertPagamento(pID, pValor, pTipoPagamento);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pValor", pValor);
            sqlc.Parameters.AddWithValue("@pTipoPagamento", pTipoPagamento);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertPagamento(int pID, double pValor, int pTipoPagamento)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PAGAMENTO (PEDIDO_PRODUTO, VL_PAGO, TIPO_PAGAMENTO) ");
            sql.Append("VALUES (@pID, @pValor, @pTipoPagamento)");

            return sql.ToString();
        }
        public void insertProduto(string pDescricao, int pTipo, double pValor, int pQtDesc, int pExibirApp, int pQtSubEstoque)
        {
            string sql = queryInsertProduto();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pTipo", pTipo);
            sqlc.Parameters.AddWithValue("@pValor", pValor);
            sqlc.Parameters.AddWithValue("@pQtDesc", pQtDesc);
            sqlc.Parameters.AddWithValue("@pExibirApp", pExibirApp);
            sqlc.Parameters.AddWithValue("@pQtSubEstoque", pQtSubEstoque);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertProduto()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PRODUTO (DESCRICAO, TIPO, VALOR, QT_DESCRICAO, MOSTRAR_LIST, EXIBIR_APP, QT_SUB_ESTOQUE, ICONE) ");
            sql.Append("VALUES (@pDescricao, @pTipo, @pValor, @pQtDesc, 0, @pExibirApp, @pQtSubEstoque, 0)");

            return sql.ToString();
        }
        public void insertFornecedor(string pCNPJ, string pNome, string pIE, string pFone, string pFantasia, int pCep, string pEnd, string pNum, string pBairro, string pCidade, string pEstado)
        {
            string sql = queryInsertFornecedor();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@CPF_CNPJ", pCNPJ);
            sqlc.Parameters.AddWithValue("@NOME", pNome);
            sqlc.Parameters.AddWithValue("@IE", pIE);
            sqlc.Parameters.AddWithValue("@FONE", pFone);
            sqlc.Parameters.AddWithValue("@NOME_FANTASIA", pFantasia);
            sqlc.Parameters.AddWithValue("@CEP", pCep);
            sqlc.Parameters.AddWithValue("@END_RUA", pEnd);
            sqlc.Parameters.AddWithValue("@END_NUM", pNum);
            sqlc.Parameters.AddWithValue("@END_BAIRRO", pBairro);
            sqlc.Parameters.AddWithValue("@END_CIDADE", pCidade);
            sqlc.Parameters.AddWithValue("@END_UF", pEstado);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertFornecedor()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO FORNECEDOR (CPF_CNPJ, NOME, IE, FONE, NOME_FANTASIA, CEP, END_RUA, END_NUM, END_BAIRRO, END_CIDADE, END_UF) ");
            sql.Append("VALUES (@CPF_CNPJ, @NOME, @IE, @FONE, @NOME_FANTASIA, @CEP, @END_RUA, @END_NUM, @END_BAIRRO, @END_CIDADE, @END_UF) ");

            return sql.ToString();
        }

        public void insertLinkProdutoxMateriaPrima(int pProduto, int pEstoque, int pQtSub)
        {
            string sql = queryinsertLinkProdutoxMateriaPrima();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pEstoque", pEstoque);
            sqlc.Parameters.AddWithValue("@pQtSub", pQtSub);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryinsertLinkProdutoxMateriaPrima()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO SUB_ESTOQUE (PRODUTO, CONTROLE_ESTOQUE, QT_SUB) ");
            sql.Append("VALUES (@pProduto, @pEstoque, @pQtSub)");

            return sql.ToString();
        }

        public void insertControleEstoque(string pDescricao, int pQTEst, int pQTEstIdeal, bool pStatus)
        {
            string sql = queryInsertControleEstoque();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pQTEst", pQTEst);
            sqlc.Parameters.AddWithValue("@pQTEstIdeal", pQTEstIdeal);
            sqlc.Parameters.AddWithValue("@pStatus", pStatus);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertControleEstoque()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO CONTROLE_ESTOQUE (DESCRICAO, QT_ESTOQUE, QT_ESTOQUE_IDEAL, STATUS) ");
            sql.Append("VALUES (@pDescricao, @pQTEst, @pQTEstIdeal, @pStatus)");

            return sql.ToString();
        }
        public void updateControleEstoque(int pID, string pDescricao, int pQTEst, int pQTEstIdeal, bool pStatus)
        {
            string sql = queryupdateControleEstoque();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pQTEst", pQTEst);
            sqlc.Parameters.AddWithValue("@pQTEstIdeal", pQTEstIdeal);
            sqlc.Parameters.AddWithValue("@pStatus", pStatus);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryupdateControleEstoque()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE CONTROLE_ESTOQUE SET ");
            sql.Append("DESCRICAO = @pDescricao, ");
            sql.Append("QT_ESTOQUE = @pQTEst, ");
            sql.Append("QT_ESTOQUE_IDEAL = @pQTEstIdeal, ");
            sql.Append("STATUS = @pStatus ");
            sql.Append("WHERE ID = @pID");

            return sql.ToString();
        }

        public void insertLinkNFxProdXfor(int pProduto, int pFornecedor, int pControle, int pQtCaixa)
        {
            string sql = queryinsertLinkNFxProdXfor();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pFornecedor", pFornecedor);
            sqlc.Parameters.AddWithValue("@pControle", pControle);
            sqlc.Parameters.AddWithValue("@pQtCaixa", pQtCaixa);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryinsertLinkNFxProdXfor()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO NFPROD_CONTROLESTQ (COD_PROD_NF, FOR_ID, COD_CONTRESTQ, QT_CAIXA) ");
            sql.Append("VALUES (@pProduto, @pFornecedor, @pControle, @pQtCaixa)");

            return sql.ToString();
        }

        public void insertLinkProdutoFinalxControleEstoque(int pProduto,int pControle, int pQtSub)
        {
            string sql = queryInsertLinkProdutoFinalxControleEstoque();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pControle", pControle);
            sqlc.Parameters.AddWithValue("@pQtSub", pQtSub);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertLinkProdutoFinalxControleEstoque()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO SUB_ESTOQUE (PRODUTO, CONTROLE_ESTOQUE, QT_SUB) ");
            sql.Append("VALUES (@pProduto, @pControle, @pQtSub)");

            return sql.ToString();
        }

        public void excluirLinkNFxProdXfor(int pID)
        {
            string sql = queryexcluirLinkNFxProdXfor();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryexcluirLinkNFxProdXfor()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM NFPROD_CONTROLESTQ WHERE ID = @pID");

            return sql.ToString();
        }

        public void excluirLinkProdutoFinalxControleEstoque(int pID)
        {
            string sql = queryExcluirLinkProdutoFinalxControleEstoque();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryExcluirLinkProdutoFinalxControleEstoque()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM SUB_ESTOQUE WHERE ID = @pID");

            return sql.ToString();
        }

        public void reimprimirPedido(int pID)
        {
            string sql = queryReimprimirPedido();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryReimprimirPedido()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO_PRODUTO SET SITUACAO = 8 WHERE PEDIDO = @pID and SITUACAO != 0 ");

            return sql.ToString();
        }

        public void insertBalde(string pNome, string pEnd, string pTel, string pBalde, int pColher = 0)
        {
            string sql = queryInsertBalde(pNome, pEnd, pTel, pBalde);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pNome", pNome.ToUpper());
            sqlc.Parameters.AddWithValue("@pEnd", pEnd.ToUpper());
            sqlc.Parameters.AddWithValue("@pTel", pTel);
            sqlc.Parameters.AddWithValue("@pBalde", pBalde);
            sqlc.Parameters.AddWithValue("@pColher", pColher);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertBalde(string pNome, string pEnd, string pTel, string pBalde)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO BALDES (NOME, ENDERECO, BALDE, TELEFONE, COLHER, DATA, ENTREGUE) ");
            sql.Append("VALUES (@pNome, @pEnd, @pBalde, @pTel, @pColher, getdate(), 0)");

            return sql.ToString();
        }

        public void insertPagamentoPedidoID(int pPedidoID, double pValor, int pTipoPagamento)
        {
            string sql = queryInsertPagamentoPedidoID(pPedidoID, pValor, pTipoPagamento);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pValor", pValor);
            sqlc.Parameters.AddWithValue("@pTipoPagamento", pTipoPagamento);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertPagamentoPedidoID(int pPedidoID, double pValor, int pTipoPagamento)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PAGAMENTO (PEDIDO_PRODUTO, VL_PAGO, TIPO_PAGAMENTO) ");
            sql.Append("VALUES (@pPedidoID, @pValor, @pTipoPagamento)");
            //sql.Append("(SELECT ID, @pValor, @pTipoPagamento FROM PEDIDO_PRODUTO WHERE PEDIDO = @pPedidoID)");

            return sql.ToString();
        }

        public void insertPagamentoNota(int pID, string pDescricao)
        {
            string sql = queryInsertPagamentoNota(pID, pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertPagamentoNota(int pID, string pDescricao)
        {
            string sql = "";
            sql = "INSERT INTO PAGAMENTO_NOTA(PAGAMENTO, DESCRICAO, CLIENTE) VALUES( ";
            sql += "(SELECT MAX(ID) FROM PAGAMENTO WHERE TIPO_PAGAMENTO = 5 AND PEDIDO_PRODUTO = @pID) , upper(@pDescricao), (select id from cliente where upper(nome) like upper(@pDescricao))) ";

            return sql.ToString();
        }
        public void insertPedido(string pDescricao, string pTipoPedido, int pSituacao, string pEnd = "", string pObs = "", int pInseridoPor = 0)
        {
            string sql = queryInsertPedido();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pTipoPedido", pTipoPedido);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pEndereco", pEnd);
            sqlc.Parameters.AddWithValue("@pObservacao", pObs);
            sqlc.Parameters.AddWithValue("@pInseridoPor", pInseridoPor);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertPedido()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PEDIDO (DESCRICAO, TIPO, SITUACAO, DT_INICIAL, ENDERECO, OBSERVACAO, INSERIDO_POR) VALUES ( ");
            //sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao)");
            sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao, getdate(), @pEndereco, @pObservacao, @pInseridoPor)");

            return sql.ToString();
        }
        //public void insertControleEstoque(string pProduto, string pDescricao, int pQtEstoque, string pUnidade, int pQtEstoqueIdeal, int pEntregaFornecedor, double pCusto, string pFornecedor, DateTime pData, bool pStatus)
        //{
        //    string sql = queryInsertControleEstoque();

        //    SqlConnection conn = conexao.retornaConexao();

        //    SqlCommand sqlc = new SqlCommand(sql);
        //    sqlc.CommandType = CommandType.Text;    
        //    sqlc.Parameters.AddWithValue("@pProduto", pProduto);
        //    sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
        //    sqlc.Parameters.AddWithValue("@pQtEstoque", pQtEstoque);
        //    sqlc.Parameters.AddWithValue("@pUnidade", pUnidade);
        //    sqlc.Parameters.AddWithValue("@pQtEstoqueIdeal", pQtEstoqueIdeal);
        //    sqlc.Parameters.AddWithValue("@pEntregaFornecedor", pEntregaFornecedor);
        //    sqlc.Parameters.AddWithValue("@pCusto", pCusto);
        //    sqlc.Parameters.AddWithValue("@pFornecedor", pFornecedor);
        //    sqlc.Parameters.AddWithValue("@pData", pData);
        //    sqlc.Parameters.AddWithValue("@pStatus", pStatus);
        //    //sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
        //    //sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
        //    //sqlc.Parameters.AddWithValue("@pEndereco", pEnd);
        //    //sqlc.Parameters.AddWithValue("@pObservacao", pObs);
        //    //sqlc.Parameters.AddWithValue("@pInseridoPor", pInseridoPor);

        //    conexao.executarInsUpDel(sqlc, conn);
        //}
        //private string queryInsertControleEstoque()
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("INSERT INTO CONTROLE_ESTOQUE (PRODUTO, DESCRICAO, QT_ESTOQUE, UNIDADE_MEDIDA, QT_ESTOQUE_IDEAL, QT_ENTREGUE_FORNECEDOR, CUSTO, FORNECEDOR, DATA_ENTREGA, STATUS) VALUES ( ");
        //    //sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao)");
        //    sql.Append("@pProduto, @pDescricao, @pQtEstoque, @pUnidade, @pQtEstoqueIdeal, @pEntregaFornecedor, @pCusto, @pFornecedor, @pData, @pStatus)");

        //    return sql.ToString();
        //}
        public void insertCliente(string pNome, string pEnd, string pTel, int pSituacao)
        {
            string sql = queryInsertCliente();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pNome", pNome);
            sqlc.Parameters.AddWithValue("@pEnd", pEnd);
            sqlc.Parameters.AddWithValue("@pContato", pTel);
            sqlc.Parameters.AddWithValue("@pStatus", pSituacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertCliente ()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO CLIENTE (NOME, ENDERECO, CONTATO, STATUS) VALUES ( ");
            sql.Append("UPPER(@pNome), UPPER(@pEnd), @pContato, @pStatus)");

            return sql.ToString();
        }

        public DataTable buscaClienteID(int pID, int pAtivo = 1)
        {
            string sql = queryBuscaClienteID(pID, pAtivo);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pStatus", pAtivo);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaClienteID(int pID, int pAtivo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, NOME, ENDERECO, CONTATO, STATUS, VALOR ");
            sql.Append("FROM CLIENTE ");
           sql.Append("WHERE 1=1 ");
            if (pAtivo != 1)
                sql.Append("AND STATUS = @pStatus ");
            if (pID > 0)
                sql.Append("AND ID = @pID");
            sql.Append("ORDER BY NOME ");
            return sql.ToString();
        }

        public DataTable buscaClienteNome(string pNome)
        {
            string sql = queryBuscaClienteNome(pNome);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pNome", pNome);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaClienteNome(string pNome)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, NOME, ENDERECO, CONTATO, STATUS, VALOR ");
            sql.Append("FROM CLIENTE ");
            if (!string.IsNullOrEmpty(pNome))
                sql.Append("WHERE NOME LIKE @pNome ");
            sql.Append("ORDER BY NOME ");
            return sql.ToString();
        }
        public DataTable buscaCategoria(string pTipo)
        {
            string sql = queryBuscaCategoria(pTipo);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pTipo", pTipo);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaCategoria(string pTipo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT DESCRICAO, TIPO, EXIBIR_APP ");
            sql.Append("FROM CATEGORIA ");
            if (!string.IsNullOrEmpty(pTipo))
                sql.Append("WHERE  DESCRICAO = @pTipo ");
            sql.Append("ORDER BY TIPO ");
            return sql.ToString();
        }
        public DataTable buscaCategoria(int pTipo)
        {
            string sql = queryBuscaCategoria(pTipo);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pTipo", pTipo);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaCategoria(int pTipo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT DESCRICAO, TIPO, EXIBIR_APP ");
            sql.Append("FROM CATEGORIA ");
            if (pTipo > 0)
                sql.Append("WHERE  TIPO = @pTipo ");
            sql.Append("ORDER BY TIPO ");
            return sql.ToString();
        }

        public DataTable buscaControleEstoque(int pID, int pStatus = 1)
        {
            string sql = queryBuscaControleEstoque(pID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pStatus", pStatus);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaControleEstoque(int pID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, QT_ESTOQUE, QT_ESTOQUE_IDEAL, STATUS ");
            sql.Append("FROM CONTROLE_ESTOQUE WHERE STATUS = @pStatus ");
            if (pID > 0)
                sql.Append(" AND ID = @pID ");
            sql.Append("ORDER BY DESCRICAO ");
            return sql.ToString();
        }
        public DataTable buscaClienteInativo(string pNome)
        {
            string sql = queryBuscaClienteInativo();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pNome", pNome);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaClienteInativo()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM CLIENTE WHERE NOME = @pNome AND STATUS = 0");
            return sql.ToString();
        }
        public void updateCliente(int pID, string pNome, string pEnd, string pContato, int pStatus)
        {
            string sql = queryUpdateCliente();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pNome", pNome);
            sqlc.Parameters.AddWithValue("@pEnd", pEnd);
            sqlc.Parameters.AddWithValue("@pContato", pContato);
            sqlc.Parameters.AddWithValue("@pStatus", pStatus);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateCliente()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE CLIENTE SET NOME = upper(@pNome), ");
            sql.Append("ENDERECO = upper(@pEnd),");
            sql.Append("CONTATO = @pContato, ");
            sql.Append("STATUS = @pStatus ");
            sql.Append("WHERE ID = @pID");

            return sql.ToString();
        }
        public void updateNotaCliente(int pID, double pValor, string pNome = "")
        {
            string sql = queryUpdateNotaCliente(pID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pValor", pValor);
            sqlc.Parameters.AddWithValue("@pNome", pNome);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateNotaCliente(int pID)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE CLIENTE SET VALOR = VALOR - @pValor ");
            if (pID > 0)
                sql.Append("WHERE ID = @pID");
            else
            {
                sql.Append("WHERE NOME LIKE @pNome");
            }

            return sql.ToString();
        }
        public void updateProduto(int pID, string pDescricao, int pTipo, double pValor, int pQtDesc, int pExibirApp, int pQtSubEstoque)
        {
            string sql = queryUpdatoProduto();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pTipo", pTipo);
            sqlc.Parameters.AddWithValue("@pValor", pValor);
            sqlc.Parameters.AddWithValue("@pQtDesc", pQtDesc);
            sqlc.Parameters.AddWithValue("@pExibirApp", pExibirApp);
            sqlc.Parameters.AddWithValue("@pQtSubEstoque", pQtSubEstoque);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdatoProduto()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE PRODUTO SET DESCRICAO = @pDescricao, ");
            sql.Append("TIPO = @pTipo,");
            sql.Append("VALOR = @pValor, ");
            sql.Append("QT_DESCRICAO = @pQtDesc, ");
            sql.Append("EXIBIR_APP = @pExibirApp, ");
            sql.Append("QT_SUB_ESTOQUE = @pQtSubEstoque ");
            sql.Append("WHERE ID = @pID ");

            return sql.ToString();
        }
        public void updateFornecedor(int pID, string pCNPJ, string pNome, string pIE, string pFone, string pFantasia, int pCep, string pEnd, string pNum, string pBairro, string pCidade, string pEstado)
        {
            string sql = queryUpdateFornecedor();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@CPF_CNPJ", pCNPJ);
            sqlc.Parameters.AddWithValue("@NOME", pNome);
            sqlc.Parameters.AddWithValue("@IE", pIE);
            sqlc.Parameters.AddWithValue("@FONE", pFone);
            sqlc.Parameters.AddWithValue("@NOME_FANTASIA", pFantasia);
            sqlc.Parameters.AddWithValue("@CEP", pCep);
            sqlc.Parameters.AddWithValue("@END_RUA", pEnd);
            sqlc.Parameters.AddWithValue("@END_NUM", pNum);
            sqlc.Parameters.AddWithValue("@END_BAIRRO", pBairro);
            sqlc.Parameters.AddWithValue("@END_CIDADE", pCidade);
            sqlc.Parameters.AddWithValue("@END_UF", pEstado);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateFornecedor()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE FORNECEDOR ");
            sql.Append("SET CPF_CNPJ =  @CPF_CNPJ, ");
            sql.Append("NOME = @NOME, ");
            sql.Append("IE = @IE, ");
            sql.Append("FONE = @FONE, ");
            sql.Append("NOME_FANTASIA = @NOME_FANTASIA, ");
            sql.Append("CEP = @CEP, ");
            sql.Append("END_RUA = @END_RUA, ");
            sql.Append("END_NUM = @END_NUM, ");
            sql.Append("END_BAIRRO = @END_BAIRRO, ");
            sql.Append("END_CIDADE = @END_CIDADE, ");
            sql.Append("END_UF = @END_UF ");
            sql.Append("FROM FORNECEDOR WHERE ID = @pID");

            return sql.ToString();
        }


        public void insertPedidoProduto(int pPedidoID, string pProduto, int pQuantidade, string pDescricao, string pObs, int pSituacao)
        //public void insertPedidoProduto(int pPedidoID, string pProduto, double pQuantidade, string pDescricao, string pObs, int pSituacao)
        {
            string sql = queryInsertPedidoProduto(pPedidoID, pProduto, pQuantidade, pDescricao, pObs, pSituacao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pQuantidade", pQuantidade);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pObs", pObs);
            //sqlc.Parameters.AddWithValue("@pTipoPedido", pTipoPedido);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        public string queryInsertPedidoProduto(int pPedidoID, string pProduto, int pQuantidade, string pDescricao, string pObs, int pSituacao)
        //    public string queryInsertPedidoProduto(int pPedidoID, string pProduto, double pQuantidade, string pDescricao, string pObs, int pSituacao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) VALUES (");
            sql.Append("@pPedidoID, ");
            sql.Append("(SELECT ID FROM PRODUTO WHERE UPPER(DESCRICAO) = UPPER(@pProduto)), ");
            sql.Append("@pQuantidade, @pDescricao, @pSituacao, ");
            //sql.Append("(SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), DATE_TRUNC('second', now()))");
            sql.Append("getdate(), upper(@pObs)) ");

            return sql.ToString();
        }
        public void insertPedidoProdutoAdicional(int pPedidoProdutoID, string pProduto, int pQuantidade, string pDescricao)
        {
            string sql = queryInsertPedidoProdutoAdicional(pPedidoProdutoID, pProduto, pQuantidade, pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoProduto", pPedidoProdutoID);
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pQuantidade", pQuantidade);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        public string queryInsertPedidoProdutoAdicional(int pPedidoProdutoID, string pProduto, int pQuantidade, string pDescricao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PEDIDO_PRODUTO_ADDS (PEDIDO_PRODUTO, PRODUTO, DESCRICAO, QT_PRODUTO, DT_ALTERACAO) VALUES (");
            sql.Append("@pPedidoProduto, ");
            sql.Append("(SELECT ID FROM PRODUTO WHERE UPPER(DESCRICAO) = UPPER(@pProduto)), ");
            sql.Append(" @pDescricao, @pQuantidade, getdate())");

            return sql.ToString();
        }

        public void updatePedidoProduto(int pPedidoProdutoID, string pProduto, int pQuantidade, string pDescricao, string pTipoPedido)
        {
            string sql = queryUpdatePedidoProduto(pPedidoProdutoID, pProduto, pQuantidade, pDescricao, pTipoPedido);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoProdutoID", pPedidoProdutoID);
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pQuantidade", pQuantidade);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pTipoPedido", pTipoPedido);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdatePedidoProduto(int pPedidoProdutoID, string pProduto, int pQuantidade, string pDescricao, string pTipoPedido)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE PEDIDO_PRODUTO SET PRODUTO = (SELECT ID FROM PRODUTO WHERE UPPER(DESCRICAO) = @pProduto), ");
            sql.Append("QT_PRODUTO = @pQuantidade, ");
            sql.Append("DESCRICAO = @pDescricao, ");
            sql.Append("TIPO = (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido) ");
            sql.Append("WHERE ID = @pPedidoProdutoID");

            return sql.ToString();
        }
        public void updateControleEstoqueCusto(int pID, string pProduto = "", int pQtEstoque= -1, int pQtEstoqueIdeal = 0, int pQtEnviadoFor = 0, double pCusto = 0, string pUnidade = "", string pFornecedor = "",string pDataEntrega = "" , int pSituacao = -1, int pAddEstoque = 0)
        {
            string sql = queryupdateControleEstoqueCusto(pID, pProduto, pQtEstoque, pQtEstoqueIdeal, pQtEnviadoFor, pCusto, pUnidade,  pFornecedor, pDataEntrega, pSituacao, pAddEstoque);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pQtEnviadoFor", pQtEnviadoFor);
            sqlc.Parameters.AddWithValue("@pCusto", pCusto);
            sqlc.Parameters.AddWithValue("@pQtEstoque", pQtEstoque);
            sqlc.Parameters.AddWithValue("@pQtEstoqueIdeal", pQtEstoqueIdeal);
            sqlc.Parameters.AddWithValue("@pUnidade", pUnidade);
            sqlc.Parameters.AddWithValue("@pFornecedor", pFornecedor);
            sqlc.Parameters.AddWithValue("@pDataEntrega", pDataEntrega);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryupdateControleEstoqueCusto(int pID, string pProduto = "", int pQtEstoque = -1, int pQtEstoqueIdeal = 0, int pQtEnviadoFor = 0, double pCusto = 0, string pUnidade = "", string pFornecedor = null, string pDataEntrega = null, int pSituacao = -1, int pAddEstoque = 0)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE CONTROLE_ESTOQUE SET ");
            if (pCusto != 0)
                sql.Append("CUSTO = @pCusto,");
            if (pSituacao != -1)
                sql.Append("SITUACAO = @pSituacao,");
            if (pAddEstoque > 0)
                sql.Append("QT_ESTOQUE = QT_ESTOQUE + QT_ENTREGUE_FORNECEDOR,");
            if (pAddEstoque < 0)
                sql.Append("QT_ESTOQUE = QT_ESTOQUE -1,");
            if (pQtEstoque > 0)
                sql.Append("QT_ESTOQUE = @pQtEstoque,");
            if (pQtEstoqueIdeal > 0)
                sql.Append("QT_ESTOQUE_IDEAL = @pQtEstoqueIdeal,");
            if (!string.IsNullOrEmpty(pFornecedor))
                sql.Append("FORNECEDOR = @pFornecedor,");
            if (!string.IsNullOrEmpty(pProduto))
                sql.Append("PRODUTO = @pProduto,");
            if (!string.IsNullOrEmpty(pUnidade))
                sql.Append("UNIDADE_MEDIDA = @pUnidade,");
            if (!string.IsNullOrEmpty(pDataEntrega))
                sql.Append("DATA_ENTREGA = @pDataEntrega,");
            if (pQtEnviadoFor > 0)
                sql.Append("QT_ENTREGUE_FORNECEDOR = @pQtEnviadoFor,");

            sql.Remove(sql.Length - 1, 1);
            sql.Append(" WHERE ID = @pID");

            return sql.ToString();
        }


        public void updateSituacaoPedidoProduto(int pPedidoProdutoID, int pSituacao, string pDescricao)
        {
            string sql = queryUpdateSituacaoPedidoProduto(pPedidoProdutoID, pSituacao, pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoProdutoID", pPedidoProdutoID);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateSituacaoPedidoProduto(int pPedidoProdutoID, int pSituacao, string pDescricao)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE PEDIDO_PRODUTO SET SITUACAO = @pSituacao, ");
            if (!string.IsNullOrEmpty(pDescricao))
                sql.Append("DESCRICAO = @pDescricao, ");
            sql.Append("DT_ALTERACAO = getdate() WHERE ID = @pPedidoProdutoID");

            return sql.ToString();
        }


        public void updatePedido(int pPedidoID, int pSituacao, string pDescricao, string pEndereco, string pObservacao)
        {
            string sql = queryUpdatePedido(pPedidoID, pSituacao, pDescricao, pEndereco, pObservacao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pEndereco", pEndereco);
            sqlc.Parameters.AddWithValue("@pObservacao", pObservacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdatePedido(int pPedidoID, int pSituacao, string pDescricao, string pEndereco, string pObservacao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO SET DESCRICAO = @pDescricao,");
            sql.Append("DT_FINAL = getdate(), ");
            sql.Append("SITUACAO = @pSituacao, ");
            sql.Append("ENDERECO = @pEndereco, ");
                sql.Append("OBSERVACAO = @pObservacao ");
                 sql.Append("WHERE ID = @pPedidoID ");

            return sql.ToString();
        }

        public void updateSituacaoPedido(int pPedidoID, string pDescricao, int pSituacao)
        {
            string sql = queryUpdateSituacaoPedido(pPedidoID, pDescricao, pSituacao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateSituacaoPedido(int pPedidoID, string pDescricao, int pSituacao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO SET SITUACAO = @pSituacao ");
            if (!string.IsNullOrEmpty(pDescricao))
                sql.Append(", DESCRICAO = CONCAT(DESCRICAO, @pDescricao), DT_FINAL = getdate() ");
            if (pSituacao == 4)
                sql.Append(", DT_FINAL = getdate() ");
            sql.Append("WHERE ID = @pPedidoID ");

            return sql.ToString();
        }
        public void updateBaldes(int pID, int pEntregue)
        {
            string sql = queryUpdateBaldes(pID, pEntregue);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);
            sqlc.Parameters.AddWithValue("@pEntregue", pEntregue);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdateBaldes(int pID, int pEntregue)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE BALDES SET ENTREGUE = @pEntregue, DATA_ENTREGA = GETDATE() ");
            sql.Append("WHERE ID = @pID ");

            return sql.ToString();
        }

        public DataTable buscaPedidosProdutosAberto(string pPedidos, bool pCheckBox)
        {
            string sql = queryBuscaPedidosProdutosAberto(pPedidos);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pCheckBox", pCheckBox);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaPedidosProdutosAberto(string pPedidos)
        {
            StringBuilder sql = new StringBuilder();
            //sql.Append("SELECT AUX.PED_PROD_ID, AUX.PRODUTO, AUX.DESC_PRODUTO, SUM(VL_ABERTO) VL_ABERTO, AUX.CHKDIVIDIR ");
            //sql.Append("FROM( ");
            //sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, ");
            ////sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) VL_ABERTO, true CHKDIVIDIR ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) VL_ABERTO, @pCheckBox CHKDIVIDIR ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            //sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            ////sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN (@pPedidos) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN (" + pPedidos + ") ");
            //sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.QT_PRODUTO, PP.DESCRICAO ");
            //sql.Append("HAVING (PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) != 0 ");
            //sql.Append("UNION ALL ");
            //sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PED_ADD.DESCRICAO DESC_PRODUTO, SUM(P2.VALOR* PED_ADD.QT_PRODUTO) VL_ABERTO, @pCheckBox CHKDIVIDIR ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO_ADDS PED_ADD ON(PP.ID = PED_ADD.PEDIDO_PRODUTO) ");
            //sql.Append("LEFT JOIN PRODUTO P2 ON(PED_ADD.PRODUTO = P2.ID) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN(" + pPedidos + ")  ");
            //sql.Append("GROUP BY PP.ID, PED_ADD.QT_PRODUTO, P2.VALOR, P.DESCRICAO, PED_ADD.DESCRICAO HAVING(PED_ADD.QT_PRODUTO* P2.VALOR) -SUM(Coalesce(PAG.VL_PAGO, 0)) != 0 ");
            //sql.Append(") AUX ");
            //sql.Append("GROUP BY AUX.PED_PROD_ID, AUX.PRODUTO, AUX.DESC_PRODUTO, AUX.CHKDIVIDIR ");

            sql.Append("SELECT AUX.PED_PROD_ID, P.DESCRICAO PRODUTO, coalesce(dbo.retorna_adicionais(AUX.PED_PROD_ID), PP.DESCRICAO) DESC_PRODUTO, SUM(AUX.VL_TOTAL) - SUM(AUX.VL_PAGO)  VL_ABERTO, AUX.CHKDIVIDIR ");
            sql.Append("FROM( ");
            sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, P.VALOR VL_PRODUTO, (PP.QT_PRODUTO * P.VALOR) VL_TOTAL, ");
            sql.Append("SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO, ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PP.QT_PRODUTO * P.VALOR) THEN 3 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) = (PP.QT_PRODUTO * P.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM, @pCheckBox CHKDIVIDIR ");
            sql.Append(" FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN(" + pPedidos + ") ");
            sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT PP.ID AS PED_PROD_ID, NULL PRODUTO, NULL DESC_PRODUTO, PED_ADD.QT_PRODUTO, P2.VALOR VL_PRODUTO, ");
            sql.Append("CASE WHEN PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN PP.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* PP.QT_PRODUTO* P2.VALOR ELSE PP.QT_PRODUTO* P2.VALOR END VL_TOTAL,  0  VL_PAGO, ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PP.QT_PRODUTO * P2.VALOR) THEN 3 ");
            sql.Append(" WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) = (PP.QT_PRODUTO * P2.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM, @pCheckBox CHKDIVIDIR ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN(" + pPedidos + ") ");
            sql.Append("GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO, PED_ADD.ID ");
            sql.Append(") AUX ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PP.ID = AUX.PED_PROD_ID) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("GROUP BY AUX.PED_PROD_ID, P.DESCRICAO, PP.DESCRICAO, AUX.CHKDIVIDIR ");

            return sql.ToString();
        }

        public DataTable buscaBaldes(int pEntregue)
        {
            string sql = queryBuscaBaldes(pEntregue);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pEntregue", pEntregue);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaBaldes(int pEntregue)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, NOME, ENDERECO, BALDE, COLHER, TELEFONE, DATA, ENTREGUE, DATA_ENTREGA ");
            sql.Append("FROM BALDES ");
            if (pEntregue != -1)
                sql.Append("WHERE ENTREGUE = @pEntregue ");
            sql.Append("ORDER BY ID DESC");

            return sql.ToString();
        }
        public DataTable buscaPedidoProdutoAdd(int pPedidoProduto)
        {
            string sql = querybuscaPedidoProdutoAdd(pPedidoProduto);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoProduto", pPedidoProduto);

            return conexao.executarSelect(sqlc, conn);
        }
        private string querybuscaPedidoProdutoAdd(int pPedidoProduto)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT PED_ADD.ID, P.DESCRICAO PRODUTO, PED_ADD.DESCRICAO, PED_ADD.QT_PRODUTO, P.VALOR, (PED_ADD.QT_PRODUTO * P.VALOR) AS VL_TOTAL ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append("JOIN PRODUTO P ON (PED_ADD.PRODUTO = P.ID) ");
            sql.Append("WHERE PED_ADD.PEDIDO_PRODUTO = @pPedidoProduto ");

            return sql.ToString();
        }

        public DataTable buscaValoresPedido(int pPedidoID)
        {
            string sql = queryBuscaValoresPedido(pPedidoID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaValoresPedido(int pPedidoID)
        {
            StringBuilder sql = new StringBuilder();

            //sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, P.VALOR VL_PRODUTO, ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) VL_TOTAL, SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO, ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO, 0)) VL_ABERTO, ");
            //sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > (PP.QT_PRODUTO * P.VALOR) THEN 3 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) = (PP.QT_PRODUTO * P.VALOR) THEN 4 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > 0 THEN 2 ELSE 1 END ORDEM ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            //sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PEDIDO = @pPedidoID ");
            //sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            //sql.Append("ORDER BY ORDEM, PRODUTO ");
            //sql.Append("SELECT AUX.PED_PROD_ID, P.DESCRICAO PRODUTO, coalesce(dbo.retorna_adicionais(AUX.PED_PROD_ID),PP.DESCRICAO) DESC_PRODUTO, AUX.QT_PRODUTO, SUM(VL_PRODUTO) VL_PRODUTO, SUM(AUX.VL_TOTAL) VL_TOTAL, AUX.VL_PAGO, SUM(AUX.VL_ABERTO) VL_ABERTO, AUX.ORDEM ");
            //sql.Append("FROM( ");
            //sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, P.VALOR VL_PRODUTO, ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) VL_TOTAL, SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO, ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO, 0)) VL_ABERTO, ");
            //sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > (PP.QT_PRODUTO * P.VALOR) THEN 3 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) = (PP.QT_PRODUTO * P.VALOR) THEN 4 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > 0 THEN 2 ELSE 1 END ORDEM ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            //sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PEDIDO = @pPedidoID ");
            //sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            //sql.Append("UNION ALL ");
            //sql.Append("SELECT PP.ID AS PED_PROD_ID, NULL PRODUTO, NULL DESC_PRODUTO, PED_ADD.QT_PRODUTO, P2.VALOR VL_PRODUTO, (PED_ADD.QT_PRODUTO * P2.VALOR) VL_TOTAL, ");
            //sql.Append("SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO, (PED_ADD.QT_PRODUTO * P2.VALOR) - SUM(Coalesce(PAG.VL_PAGO, 0)) VL_ABERTO, ");
            //sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 3 ");
            //sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) = (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 4 ");
            //sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > 0 THEN 2 ELSE 1 END ORDEM ");
            //sql.Append("FROM  PEDIDO_PRODUTO_ADDS PED_ADD ");
            //sql.Append("LEFT JOIN  PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PEDIDO = @pPedidoID ");
            //sql.Append("GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO ");
            //sql.Append(") AUX ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PP.ID = AUX.PED_PROD_ID) ");
            //sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            //sql.Append("GROUP BY AUX.PED_PROD_ID, AUX.QT_PRODUTO, AUX.VL_PAGO,  AUX.ORDEM, P.DESCRICAO, PP.DESCRICAO ");

            sql.Append("SELECT AUX.PED_PROD_ID, P.DESCRICAO PRODUTO, coalesce(dbo.retorna_adicionais(AUX.PED_PROD_ID),PP.DESCRICAO) DESC_PRODUTO, AUX.QT_PRODUTO, SUM(VL_PRODUTO) VL_PRODUTO, SUM(AUX.VL_TOTAL) VL_TOTAL, sum(AUX.VL_PAGO) VL_PAGO, SUM(AUX.VL_TOTAL) - SUM(AUX.VL_PAGO)  VL_ABERTO /*SUM(AUX.VL_ABERTO) VL_ABERTO, AUX.ORDEM*/ ");
            sql.Append("FROM ( ");
            sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, ");
            sql.Append(" P.VALOR VL_PRODUTO, (PP.QT_PRODUTO * P.VALOR) VL_TOTAL,  ");
            sql.Append("SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO/*, (PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) VL_ABERTO*/,  ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PP.QT_PRODUTO * P.VALOR) THEN 3 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) = (PP.QT_PRODUTO * P.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append(" WHERE PP.SITUACAO IN(1, 2,8) AND PEDIDO =  @pPedidoID ");
            sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            sql.Append(" UNION ALL ");
            sql.Append("SELECT PP.ID AS PED_PROD_ID, NULL PRODUTO, NULL DESC_PRODUTO, PP.QT_PRODUTO, (P2.VALOR * PED_ADD.QT_PRODUTO) VL_PRODUTO, ");
            sql.Append("CASE WHEN PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN PP.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* PP.QT_PRODUTO* P2.VALOR ELSE PP.QT_PRODUTO * P2.VALOR END VL_TOTAL, ");
            sql.Append("0  VL_PAGO /*, (PP.QT_PRODUTO * P2.VALOR) - (SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*)) VL_ABERTO*/,  ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 3 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) = (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append(" LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            sql.Append("WHERE PP.SITUACAO IN(1, 2,8) AND PEDIDO =  @pPedidoID ");
            sql.Append(" GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO, PED_ADD.ID ");
            sql.Append(") AUX ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PP.ID = AUX.PED_PROD_ID) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("GROUP BY AUX.PED_PROD_ID, AUX.QT_PRODUTO, P.DESCRICAO, PP.DESCRICAO/*,  AUX.ORDEM */");

            return sql.ToString();
        }



        public DataTable buscaProdutoFilho(string pProdutoPai)
        {
            string sql = queryBuscaProdutoFilho(pProdutoPai);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pProdutoPai", pProdutoPai);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaProdutoFilho(string pProdutoPai)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM PRODUTO WHERE TIPO = (SELECT TIPO FROM CATEGORIA WHERE DESCRICAO = @pProdutoPai) AND EXIBIR_APP = 1 ");
            sql.Append("ORDER BY DESCRICAO ");

            return sql.ToString();
        }
        public DataTable buscaProduto(int pID)
        {
            string sql = queryBuscaProduto();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaProduto()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO, TIPO, VALOR, QT_DESCRICAO, MOSTRAR_LIST, EXIBIR_APP, QT_SUB_ESTOQUE FROM PRODUTO WHERE ID = @pID ");

            return sql.ToString();
        }
        public DataTable buscaFornecedor(int pID)
        {
            string sql = queryBuscaFornecedor();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaFornecedor()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, CPF_CNPJ, NOME, IE, FONE, NOME_FANTASIA, CEP, END_RUA, END_NUM, END_BAIRRO, END_CIDADE, END_UF FROM FORNECEDOR WHERE ID = @pID ");

            return sql.ToString();
        }
        public DataTable buscaSabor(string pDescricao)
        {
            string sql = queryBuscaSabor(pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaSabor(string pDescricao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM SABOR WHERE TIPO = @pDescricao ");
            sql.Append("ORDER BY DESCRICAO ");

            return sql.ToString();
        }

        public DataTable buscaDescPedidoAberto(string pDescricao)
        {
            string sql = queryBuscaDescPedidoAberto(pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaDescPedidoAberto(string pDescricao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM PEDIDO WHERE  DESCRICAO = @pDescricao AND SITUACAO IN (1,2,3) ");

            return sql.ToString();
        }

        public DataTable buscaProdutoPai()
        {
            string sql = queryBuscaProdutoPai();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            //sqlc.Parameters.AddWithValue("@pProdutoPai", pProdutoPai);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaProdutoPai()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TIPO ID, DESCRICAO FROM CATEGORIA WHERE EXIBIR_APP = 1 ORDER BY TIPO ");

            return sql.ToString();
        }

        public DataTable buscaTipoPedido()
        {
            string sql = queryBuscaTipoPedido();

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            //sqlc.Parameters.AddWithValue("@pProdutoPai", pProdutoPai);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaTipoPedido()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, DESCRICAO FROM TIPO_PEDIDO ");

            return sql.ToString();
        }
        public DataTable buscaUltimoPedido(string pDescPedido)
        {
            string sql = queryBuscaUltimoPedido(pDescPedido);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pDescPedido", pDescPedido);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaUltimoPedido(string pDescPedido)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT MAX(ID) FROM PEDIDO WHERE DESCRICAO = @pDescPedido");

            return sql.ToString();
        }

        public DataTable buscaPedidoProdutoAberto(int pPedidoID)
        {
            string sql = queryBuscaPedidoProdutoAberto(pPedidoID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaPedidoProdutoAberto(int pPedidoID)
        {
            StringBuilder sql = new StringBuilder();

            //sql.Append("SELECT PP.ID ID_PEDIDO_PRODUTO, PRO.ID ID_PRODUTO, PRO.DESCRICAO PRODUTO, PP.DESCRICAO, ");
            ////sql.Append("CASE WHEN PP.TIPO = 1 THEN 'CONSUMIR' WHEN PP.TIPO = 2 THEN 'LEVAR' WHEN PP.TIPO = 3 THEN 'ENTREGAR' END TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            //sql.Append("NULL TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            //sql.Append("(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            //sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            //sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            //sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            //sql.Append("UNION ALL ");
            //sql.Append("SELECT NULL, NULL, 'VL. TOTAL', NULL, NULL, SUM(PP.QT_PRODUTO) QUANTIDADE, SUM(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            //sql.Append("FROM PEDIDO_PRODUTO PP ");
            //sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            //sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            //sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            //sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            //sql.Append("GROUP BY PED.ID ");

            sql.Append("SELECT A.ID_PEDIDO_PRODUTO, A.ID_PRODUTO, A.PRODUTO, CONCAT(A.DESCRICAO, dbo.retorna_adicionais(A.ID_PEDIDO_PRODUTO)) DESCRICAO, A.TIPO, SUM(QUANTIDADE) QUANTIDADE , SUM(VALOR) VALOR ");
            sql.Append("FROM( ");
            sql.Append("SELECT PP.ID ID_PEDIDO_PRODUTO, PRO.ID ID_PRODUTO, PRO.DESCRICAO PRODUTO, PP.DESCRICAO, NULL TIPO, PP.QT_PRODUTO QUANTIDADE, (PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            sql.Append(" ");
            sql.Append("UNION ALL ");
            sql.Append(" ");
            sql.Append("SELECT PP.ID ID_PEDIDO_PRODUTO, PP.PRODUTO ID_PRODUTO, (SELECT DESCRICAO FROM PRODUTO WHERE ID = PP.PRODUTO) PRODUTO, PP.DESCRICAO DESCRICAO, NULL TIPO, 0 QUANTIDADE, ");
            sql.Append("CASE WHEN (PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1) OR (PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO = 1) THEN PED_ADD.QT_PRODUTO* P2.VALOR  ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN PP.QT_PRODUTO* P2.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* PP.QT_PRODUTO* P2.VALOR END VL_TOTAL ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append(" ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append(" ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append(" ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            sql.Append(" ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PEDIDO = @pPedidoID ");
            sql.Append(" ");
            sql.Append("GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO, PP.PRODUTO, PP.DESCRICAO ");
            sql.Append(") A ");
            sql.Append("GROUP BY A.ID_PEDIDO_PRODUTO, A.ID_PRODUTO, A.PRODUTO, A.DESCRICAO, A.TIPO ");
            sql.Append("UNION ALL ");
            sql.Append(" ");
            sql.Append("SELECT B.ID_PEDIDO_PRODUTO, B.ID_PRODUTO, B.PRODUTO, B.DESCRICAO, B.TIPO, SUM(B.QUANTIDADE) , SUM(B.VALOR) VALOR ");
            sql.Append("FROM( ");
            sql.Append("SELECT NULL ID_PEDIDO_PRODUTO, NULL ID_PRODUTO, 'VL. TOTAL' PRODUTO, NULL DESCRICAO, NULL TIPO, SUM(PP.QT_PRODUTO) QUANTIDADE, SUM(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID GROUP BY PED.ID ");
            sql.Append(" ");
            sql.Append("UNION ALL ");
            sql.Append(" ");
            sql.Append("SELECT NULL, NULL, 'VL. TOTAL', NULL, NULL, 0 QUANTIDADE, ");
            sql.Append("SUM( CASE WHEN PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* P.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN PP.QT_PRODUTO* P.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN PED_ADD.QT_PRODUTO* PP.QT_PRODUTO* P.VALOR ");
            sql.Append("ELSE PP.QT_PRODUTO* P.VALOR END ) VALOR ");
            //sql.Append("SUM(CASE WHEN PP.QT_PRODUTO = 1 AND PED_ADD.QT_PRODUTO > 1 THEN(PED_ADD.QT_PRODUTO * P.VALOR) ");
            //sql.Append(" ");
            //sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO = 1 THEN(PP.QT_PRODUTO * P.VALOR) ");
            //sql.Append(" ");
            //sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED_ADD.QT_PRODUTO > 1 THEN(PED_ADD.QT_PRODUTO * PP.QT_PRODUTO * P.VALOR) END) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PED_ADD.PRODUTO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PP.PEDIDO = @pPedidoID GROUP BY PP.PEDIDO) B ");
            sql.Append("GROUP BY B.ID_PEDIDO_PRODUTO, B.ID_PRODUTO, B.PRODUTO, B.DESCRICAO, B.TIPO ");

            return sql.ToString();
        }

        public DataTable buscaInformacoesPedido(int pPedidoID)
        {
            string sql = queryBuscaInformacoesPedido(pPedidoID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaInformacoesPedido(int pPedidoID)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT PED.ID, PED.DESCRICAO DESCRICAO, (SELECT DESCRICAO FROM TIPO_PEDIDO WHERE ID =  PED.TIPO) TIPO, ");
            sql.Append("PED.SITUACAO SITUACAO_ID, CASE WHEN SITUACAO BETWEEN 1 AND 3 THEN 'ABERTO' WHEN SITUACAO = 0 THEN 'CANCELADO' WHEN SITUACAO = 4 THEN 'PAGO' ELSE 'ENTREGA' END DESC_SITUACAO, CONCAT(ENDERECO, ' - ', OBSERVACAO) AS END_OBS ");
            sql.Append("FROM PEDIDO PED WHERE PED.ID = @pPedidoID ");

            return sql.ToString();
        }

        

        public DataTable retornaDataTable(string pSQL)
            {
            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(pSQL);
            sqlc.CommandType = CommandType.Text;

            return conexao.executarSelect(sqlc, conn);
        }

        public DataTable buscaPedidoProdutoCampos(int pPedidoProdutoID)
        {
            string sql = queryBuscaPedidoProdutoCampos(pPedidoProdutoID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoProdutoID", pPedidoProdutoID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaPedidoProdutoCampos(int pPedidoProdutoID)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT PPAI.DESCRICAO CATEGORIA, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(P.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.ID = @pPedidoProdutoID ");

            return sql.ToString();
        }

        public void executaQueryTransaction (SqlConnection pConexao, SqlCommand pSQLCommand)
        {
            pSQLCommand.Connection = pConexao;
            pSQLCommand.ExecuteNonQuery();
        }

        public DataTable retornaDataTableTransaction (SqlConnection pConexao, SqlCommand pSQLCommand)
        {
            DataTable dtRetorno = new DataTable();
            pSQLCommand.Connection = pConexao;
            SqlDataReader sqlReader = pSQLCommand.ExecuteReader();

            DataTable tbEsquema = sqlReader.GetSchemaTable();

            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!dtRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    dtRetorno.Columns.Add(col);
                }
            }

            while (sqlReader.Read())
            {
                DataRow novaLinha = dtRetorno.NewRow();
                for (int i = 0; i < dtRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = sqlReader.GetValue(i);
                }
                dtRetorno.Rows.Add(novaLinha);
            }

            sqlReader.Close();

            return dtRetorno;
        }

        public DataTable retornaTeste()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CONCAT(/*PED.ID, ' - ',*/PED.DESCRICAO, ' - ', COALESCE(CONCAT(CONVERT(VARCHAR, PP.DT_ALTERACAO, 103), ' ', CONVERT(VARCHAR, PP.DT_ALTERACAO, 108)), NULL)) DESC_PEDIDO, PED.TIPO, PED.ENDERECO, PED.OBSERVACAO OBS_PED, PP.ID PED_PROD_ID, ");
            sql.Append("P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.OBSERVACAO OBS_PRODUTO, PP.QT_PRODUTO,(PP.QT_PRODUTO * P.VALOR) VL_TOTAL ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("WHERE PP.SITUACAO = 8 AND PED.ID = (SELECT MIN(PPA.PEDIDO) DT FROM PEDIDO_PRODUTO PPA JOIN PEDIDO PA ON (PPA.PEDIDO = PA.ID) WHERE PPA.SITUACAO = 8 AND PA.SITUACAO IN (1,2)) ");
            sql.Append("GROUP BY P.ID, PED.TIPO, PED.ENDERECO, PED.OBSERVACAO, PED.ID, PP.ID, PED.DESCRICAO, PP.DT_ALTERACAO, P.DESCRICAO, PP.DESCRICAO, PP.OBSERVACAO, PP.QT_PRODUTO, P.VALOR ");
            sql.Append("ORDER BY DESC_PEDIDO, PRODUTO ");
            //sql.Append("SELECT CONCAT(PED.ID, ' - ',PED.MESA, ' - ', COALESCE(TO_CHAR(PP.DT_ALTERACAO, 'DD/MM/YYYY HH24:MI:SS'), NULL)) DESC_PEDIDO, PP.ID PED_PROD_ID, ");
            //sql.Append("P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO,(PP.QT_PRODUTO * P.VALOR) VL_TOTAL ");
            //sql.Append("FROM PEDIDO PED ");
            //sql.Append("JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            //sql.Append("JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            //sql.Append("WHERE PP.SITUACAO = 8 AND PED.ID = (SELECT PEDIDO FROM PEDIDO_PRODUTO WHERE DT_ALTERACAO = (SELECT MIN(DT_ALTERACAO) DT FROM PEDIDO_PRODUTO WHERE SITUACAO = 8)) ");
            //sql.Append("GROUP BY P.ID, PED.ID, PP.ID ");
            //sql.Append("ORDER BY PRODUTO ");

            return conexao.executarSelect(sql.ToString());
        }

        public DataTable retornaPedidosAdds(int pPP)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT PED.ID, PED.PEDIDO_PRODUTO, P.DESCRICAO PRODUTO, PED.DESCRICAO, PED.QT_PRODUTO, PED.DT_ALTERACAO, ");
            sql.Append("CASE WHEN PP.QT_PRODUTO = 1 AND PED.QT_PRODUTO > 1 THEN PED.QT_PRODUTO* P.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED.QT_PRODUTO = 1 THEN PP.QT_PRODUTO* P.VALOR ");
            sql.Append("WHEN PP.QT_PRODUTO > 1 AND PED.QT_PRODUTO > 1 THEN PED.QT_PRODUTO* PP.QT_PRODUTO* P.VALOR ELSE PP.QT_PRODUTO * P.VALOR END VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED ");
            sql.Append("JOIN PRODUTO P ON(PED.PRODUTO = P.ID) ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON (PP.ID = PED.PEDIDO_PRODUTO) ");
            sql.Append("WHERE PED.PEDIDO_PRODUTO = "+ pPP);

            return conexao.executarSelect(sql.ToString());
        }

        public DataTable relVendas(int pSituacao, string pProdutoPai, string pProdutoFilho, string pDescricao, Nullable<DateTime> pDTInicial, Nullable<DateTime> pDTFinal)
        {
            SqlConnection conn = conexao.retornaConexao();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COALESCE(PPAI.DESCRICAO, 'OUTROS') PRODUTO_PAI, PRO.DESCRICAO PRODUTO_FILHO, PP.DESCRICAO PRODUTO_DESCRICAO, ");
            sql.Append("SUM(PP.QT_PRODUTO) QT, SUM(PG.VL_PAGO) VALOR, PP.DT_ALTERACAO DT_HORA ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("JOIN PRODUTO PRO ON(PRO.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PAGAMENTO PG ON(PP.ID = PG.PEDIDO_PRODUTO) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(PPAI.TIPO = PRO.TIPO) ");
            sql.Append("WHERE 1=1 ");
            //sql.Append("SELECT PPAI.DESCRICAO PRODUTO_PAI, PRO.DESCRICAO PRODUTO_FILHO, PP.DESCRICAO PRODUTO_DESCRICAO, SUM(PP.QT_PRODUTO) QT, SUM(PP.QT_PRODUTO * PRO.VALOR) VALOR, PP.DT_ALTERACAO DT_HORA ");
            //sql.Append("FROM PEDIDO PED ");
            //sql.Append("JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            //sql.Append("JOIN PRODUTO PRO ON(PRO.ID = PP.PRODUTO) ");
            //sql.Append("JOIN PRODUTO_PAI PPAI ON(PPAI.TIPO = PRO.TIPO) ");
            //sql.Append("WHERE 1 = 1 ");
            if (pSituacao > -1)
                sql.Append(" AND PP.SITUACAO = @pSituacao");
            if (!string.IsNullOrEmpty(pProdutoPai))
                sql.Append(" AND PPAI.DESCRICAO = @pProdutoPai");
            if (!string.IsNullOrEmpty(pProdutoFilho))
                sql.Append(" AND PRO.DESCRICAO = @pProdutoFilho");
            if (!string.IsNullOrEmpty(pDescricao))
                sql.Append(" AND PP.DESCRICAO like @pDescricao");
            if (pDTInicial != null)
            {
                if (pDTFinal != null)
                {
                    sql.Append(" AND PP.DT_ALTERACAO BETWEEN @pDTInicial AND @pDTFinal ");
                }
            }
            sql.Append("GROUP BY PRO.DESCRICAO, PPAI.DESCRICAO, PP.DESCRICAO, PP.DT_ALTERACAO, PPAI.TIPO ");
            sql.Append("ORDER BY PPAI.TIPO ");

            /*sql.Append("UNION ALL ");

            sql.Append("SELECT 'CANCELADO' PRODUTO_PAI, PRO.DESCRICAO PRODUTO_FILHO, PP.DESCRICAO PRODUTO_DESCRICAO, SUM(PP.QT_PRODUTO) QT, PRO.VALOR VALOR, ");
            sql.Append("PP.DT_ALTERACAO DT_HORA, 2 ORDEM ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("JOIN PRODUTO PRO ON(PRO.ID = PP.PRODUTO) ");
            sql.Append("WHERE PP.SITUACAO = 0 ");
            if (pSituacao > -1)
                sql.Append(" AND PP.SITUACAO = @pSituacao");
            if (!string.IsNullOrEmpty(pProdutoPai))
                sql.Append(" AND PPAI.DESCRICAO = @pProdutoPai");
            if (!string.IsNullOrEmpty(pProdutoFilho))
                sql.Append(" AND PRO.DESCRICAO = @pProdutoFilho");
            if (!string.IsNullOrEmpty(pDescricao))
                sql.Append(" AND PP.DESCRICAO like @pDescricao");
            if (pDTInicial != null)
            {
                if (pDTFinal != null)
                {
                    sql.Append(" AND PP.DT_ALTERACAO BETWEEN @pDTInicial AND @pDTFinal ");
                }
            }
            sql.Append("GROUP BY PRO.DESCRICAO, PP.DESCRICAO, PP.DT_ALTERACAO, PRO.VALOR ");
            sql.Append("ORDER BY ORDEM, 1 ");

            //sql.Append("GROUP BY PPAI.TIPO, PRO.ID, PP.DESCRICAO, PP.DT_ALTERACAO ");
            //sql.Append("ORDER BY PPAI.TIPO ");
            */

            SqlCommand sqlc = new SqlCommand(sql.ToString());
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pProdutoPai", pProdutoPai);
            sqlc.Parameters.AddWithValue("@pProdutoFilho", pProdutoFilho);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pDTInicial", pDTInicial);
            sqlc.Parameters.AddWithValue("@pDTFinal", pDTFinal);

            return conexao.executarSelect(sqlc, conn);
        }

        public DataTable relVendasDia(string pData)
        {
            DataTable dt;
            SqlConnection conn = conexao.retornaConexao();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COALESCE(PPAI.DESCRICAO, 'OUTROS') DESCRICAO, SUM(PG.VL_PAGO) VALOR, 1 TIPO ");
            sql.Append("FROM CATEGORIA PPAI ");
            sql.Append("RIGHT JOIN PRODUTO PFILHO ON(PPAI.TIPO = PFILHO.TIPO) ");
            sql.Append("RIGHT JOIN PEDIDO_PRODUTO PP ON(PP.PRODUTO = PFILHO.ID) ");
            sql.Append("RIGHT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE /*PP.SITUACAO = 3 AND*/ convert(varchar, PG.DT_PAGAMENTO, 103) = '" + pData + "' ");
            sql.Append("GROUP BY PPAI.DESCRICAO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT TP.DESCRICAO DESCRICAO, SUM(PG.VL_PAGO) VALOR, 2 TIPO ");
            sql.Append("FROM PRODUTO PFILHO ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PP.PRODUTO = PFILHO.ID) ");
            sql.Append("JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("JOIN TIPO_PAGAMENTO TP ON (TP.ID = PG.TIPO_PAGAMENTO) ");
            sql.Append("WHERE /*PP.SITUACAO = 3 AND*/ convert(varchar, PG.DT_PAGAMENTO, 103) = '" + pData + "' ");
            sql.Append("GROUP BY TP.DESCRICAO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT DESCRICAO, VALOR, 3 TIPO ");
            sql.Append("FROM RETIRADA_CAIXA ");
            sql.Append("WHERE convert(varchar, DATA, 103) = '" + pData + "' ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT CONCAT(PFILHO.DESCRICAO, ' - ', PP.DESCRICAO), SUM(PG.VL_PAGO) VALOR, 1 TIPO ");
            sql.Append("FROM CATEGORIA PPAI ");
            sql.Append("RIGHT JOIN PRODUTO PFILHO ON(PPAI.TIPO = PFILHO.TIPO) ");
            sql.Append("RIGHT JOIN PEDIDO_PRODUTO PP ON(PP.PRODUTO = PFILHO.ID) ");
            sql.Append("RIGHT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE PP.SITUACAO = 0 AND convert(varchar, PG.DT_PAGAMENTO, 103) = '" + pData + "' ");
            sql.Append("GROUP BY CONCAT(PFILHO.DESCRICAO, ' - ', PP.DESCRICAO) ");



            SqlCommand sqlc = new SqlCommand(sql.ToString());
            sqlc.CommandType = CommandType.Text;

            dt = conexao.executarSelect(sqlc, conn);
            conn.Close();


            return dt;
        }


        public void excluirPedidoProdutoAdicional(int pID)
        {
            string sql = queryExcluirPedidoProdutoAdicional(pID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryExcluirPedidoProdutoAdicional(int pID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM PEDIDO_PRODUTO_ADDS WHERE ID = @pID ");

            return sql.ToString();
        }

    }
}
