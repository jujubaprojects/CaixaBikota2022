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

            sql.Append("SELECT TAB.PEDIDO ID, TAB.DESCRICAO, TAB.HORA, SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) VL_TOTAL,  ");
            sql.Append("SUM(COALESCE(PG.VL_PAGO, 0)) VL_PAGO, SUM(TAB.VL_PRODUTO * TAB.QT_PRODUTO) - SUM(COALESCE(PG.VL_PAGO, 0)) VL_ABERTO ");
            sql.Append("FROM(SELECT PED.ID PEDIDO, PP.ID PED_PROD_ID, PED.MESA DESCRICAO, PP.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, ");
            sql.Append("P.VALOR AS VL_PRODUTO, PP.QT_PRODUTO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
                sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) AND PED.TIPO = @pTipo ");
            else
                sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) AND PED.TIPO = @pTipo ");
            sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData) TAB ");
            sql.Append("LEFT JOIN ");
            sql.Append("(SELECT PEDIDO_PRODUTO, SUM(VL_PAGO) VL_PAGO FROM PAGAMENTO GROUP BY PEDIDO_PRODUTO) PG ON(TAB.PED_PROD_ID = PG.PEDIDO_PRODUTO) ");
            sql.Append("GROUP BY TAB.PEDIDO, TAB.DESCRICAO, TAB.HORA ");


            //sql.Append("SELECT PED.ID, PED.MESA DESCRICAO, TO_CHAR(DT_INICIAL, 'HH24:MI:SS') HORA, ");
            //sql.Append("Coalesce(SUM(PP.QT_PRODUTO * P.VALOR), 0) VL_TOTAL, ");
            //sql.Append("Coalesce(SUM(PG.VL_PAGO), 0) VL_PAGO, ");
            //sql.Append("Coalesce(SUM(PP.QT_PRODUTO * P.VALOR), 0) - Coalesce(SUM(PG.VL_PAGO), 0) VL_ABERTO ");
            //sql.Append("FROM PEDIDO PED ");
            //sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            //sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            //sql.Append("LEFT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");

            //if (pSituacao <= 3 && pSituacao > 0)//ABERTO;FILA;ANDAMENTO
            //    sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN (1,2,3) AND PED.TIPO = @pTipo ");
            //else
            //    sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) AND PED.TIPO = @pTipo ");
            //sql.Append("AND TO_CHAR(DT_INICIAL, 'DD/MM/YYYY') = @pData ");
            //sql.Append("GROUP BY PED.ID, PED.MESA ");

            return sql.ToString();

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
            sql = "INSERT INTO PAGAMENTO_NOTA(PAGAMENTO, DESCRICAO) VALUES( ";
            sql += "(SELECT MAX(ID) FROM PAGAMENTO WHERE TIPO_PAGAMENTO = 4 AND PEDIDO_PRODUTO = @pID) , @pDescricao) ";

            return sql.ToString();
        }
        public void insertPedido(string pDescricao, string pTipoPedido, int pSituacao)
        {
            string sql = queryInsertPedido(pDescricao, pTipoPedido, pSituacao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pTipoPedido", pTipoPedido);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryInsertPedido(string pDescricao, string pTipoPedido, int pSituacao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PEDIDO (MESA, TIPO, SITUACAO) VALUES ( ");
            sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao)");

            return sql.ToString();
        }


        public void insertPedidoProduto(int pPedidoID, string pProduto, int pQuantidade, string pDescricao, int pSituacao)
        {
            string sql = queryInsertPedidoProduto(pPedidoID, pProduto, pQuantidade, pDescricao, pSituacao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pProduto", pProduto);
            sqlc.Parameters.AddWithValue("@pQuantidade", pQuantidade);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);
            //sqlc.Parameters.AddWithValue("@pTipoPedido", pTipoPedido);
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        public string queryInsertPedidoProduto(int pPedidoID, string pProduto, int pQuantidade, string pDescricao, int pSituacao)
        {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO) VALUES (");
                sql.Append("@pPedidoID, ");
                sql.Append("(SELECT ID FROM PRODUTO WHERE UPPER(DESCRICAO) = UPPER(@pProduto)), ");
                sql.Append("@pQuantidade, @pDescricao, @pSituacao, ");
            //sql.Append("(SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), DATE_TRUNC('second', now()))");
            sql.Append("getdate() ) ");

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


        public void updatePedido(int pPedidoID, int pSituacao, string pDescricao)
        {
            string sql = queryUpdatePedido(pPedidoID, pSituacao, pDescricao);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pSituacao", pSituacao);
            sqlc.Parameters.AddWithValue("@pPedidoID", pPedidoID);
            sqlc.Parameters.AddWithValue("@pDescricao", pDescricao);

            conexao.executarInsUpDel(sqlc, conn);
        }
        private string queryUpdatePedido(int pPedidoID, int pSituacao, string pDescricao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO SET MESA = CONCAT('CANCELADO ', MESA, ' - Motivo: ' , @pDescricao),");
            sql.Append("DT_FINAL = DATE_TRUNC('second',now()), ");
            sql.Append("SITUACAO = @pSituacao WHERE ID = @pPedidoID ");

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
        private string queryUpdateSituacaoPedido (int pPedidoID, string pDescricao, int pSituacao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE PEDIDO SET SITUACAO = @pSituacao ");
            if (!string.IsNullOrEmpty(pDescricao))
                sql.Append(", MESA = CONCAT(MESA, @pDescricao), DT_FINAL = DATE_TRUNC('second',now())");
            sql.Append("WHERE ID = @pPedidoID ");

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
            sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, ");
            //sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) VL_ABERTO, true CHKDIVIDIR ");
            sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) VL_ABERTO, @pCheckBox CHKDIVIDIR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            //sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN (@pPedidos) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN ("+pPedidos+") ");
            sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.QT_PRODUTO, PP.DESCRICAO ");
            sql.Append("HAVING (PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO,0)) != 0 ");

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

            sql.Append("SELECT PP.ID AS PED_PROD_ID, P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, P.VALOR VL_PRODUTO, ");
            sql.Append("(PP.QT_PRODUTO * P.VALOR) VL_TOTAL, SUM(Coalesce(PAG.VL_PAGO, 0)) VL_PAGO, ");
            sql.Append("(PP.QT_PRODUTO * P.VALOR) - SUM(Coalesce(PAG.VL_PAGO, 0)) VL_ABERTO, ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > (PP.QT_PRODUTO * P.VALOR) THEN 3 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) = (PP.QT_PRODUTO * P.VALOR) THEN 4 WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) > 0 THEN 2 ELSE 1 END ORDEM ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PEDIDO = @pPedidoID ");
            sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            sql.Append("ORDER BY ORDEM, PRODUTO ");

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
            sql.Append("SELECT * FROM PRODUTO WHERE TIPO = (SELECT TIPO FROM PRODUTO_PAI WHERE DESCRICAO = @pProdutoPai) ");
            sql.Append("ORDER BY DESCRICAO ");

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
            sql.Append("SELECT * FROM PEDIDO WHERE  MESA = @pDescricao AND SITUACAO IN (1,2,3) ");

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
            sql.Append("SELECT TIPO ID, DESCRICAO FROM PRODUTO_PAI ORDER BY TIPO ");

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
            sql.Append("SELECT MAX(ID) FROM PEDIDO WHERE MESA = @pDescPedido");

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

            sql.Append("SELECT PP.ID ID_PEDIDO_PRODUTO, PRO.ID ID_PRODUTO, PRO.DESCRICAO PRODUTO, PP.DESCRICAO, ");
            //sql.Append("CASE WHEN PP.TIPO = 1 THEN 'CONSUMIR' WHEN PP.TIPO = 2 THEN 'LEVAR' WHEN PP.TIPO = 3 THEN 'ENTREGAR' END TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            sql.Append("NULL TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            sql.Append("(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN PRODUTO_PAI PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT NULL, NULL, 'VL. TOTAL', NULL, NULL, SUM(PP.QT_PRODUTO) QUANTIDADE, SUM(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN PRODUTO_PAI PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            sql.Append("GROUP BY PED.ID ");

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

            sql.Append("SELECT PED.ID, PED.MESA DESCRICAO, (SELECT DESCRICAO FROM TIPO_PEDIDO WHERE ID =  PED.TIPO) TIPO, ");
            sql.Append("PED.SITUACAO SITUACAO_ID, CASE WHEN SITUACAO BETWEEN 1 AND 3 THEN 'ABERTO' WHEN SITUACAO = 0 THEN 'CANCELADO' WHEN SITUACAO = 4 THEN 'PAGO' ELSE 'ENTREGA' END DESC_SITUACAO ");
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

            sql.Append("SELECT PPAI.DESCRICAO PRODUTO_PAI, P.DESCRICAO PRODUTO_FILHO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO, ");
            sql.Append("(SELECT DESCRICAO FROM TIPO_PEDIDO WHERE ID = PP.TIPO) TIPO ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("LEFT JOIN PRODUTO_PAI PPAI ON(P.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.ID = @pPedidoProdutoID ");

            return sql.ToString();
        }

        public void executaQueryTransaction (SqlConnection pConexao, SqlCommand pSQLCommand)
        {
            pSQLCommand.Connection = pConexao;
            pSQLCommand.ExecuteNonQuery();
        }

        public DataTable retornaTeste()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CONCAT(PED.ID, ' - ',PED.MESA, ' - ', COALESCE(CONCAT(CONVERT(VARCHAR, PP.DT_ALTERACAO, 103), ' ', CONVERT(VARCHAR, PP.DT_ALTERACAO, 108)), NULL)) DESC_PEDIDO, PP.ID PED_PROD_ID, ");
            sql.Append("P.DESCRICAO PRODUTO, PP.DESCRICAO DESC_PRODUTO, PP.QT_PRODUTO,(PP.QT_PRODUTO * P.VALOR) VL_TOTAL ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("JOIN PRODUTO P ON(PP.PRODUTO = P.ID) ");
            sql.Append("WHERE PP.SITUACAO = 8 AND PED.ID = (SELECT DISTINCT PEDIDO FROM PEDIDO_PRODUTO WHERE DT_ALTERACAO = (SELECT MIN(DT_ALTERACAO) DT FROM PEDIDO_PRODUTO PPA JOIN PEDIDO PA ON (PPA.PEDIDO = PA.ID) WHERE PPA.SITUACAO = 8 AND PA.SITUACAO IN (1,2))) ");
            sql.Append("GROUP BY P.ID, PED.ID, PP.ID, PED.MESA, PP.DT_ALTERACAO, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO, P.VALOR ");
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

        public DataTable relVendas(int pSituacao, string pProdutoPai, string pProdutoFilho, string pDescricao, Nullable<DateTime> pDTInicial, Nullable<DateTime> pDTFinal)
        {
            SqlConnection conn = conexao.retornaConexao();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COALESCE(PPAI.DESCRICAO, 'OUTROS') PRODUTO_PAI, PRO.DESCRICAO PRODUTO_FILHO, PP.DESCRICAO PRODUTO_DESCRICAO, ");
            sql.Append("SUM(PP.QT_PRODUTO) QT, SUM(PG.VL_PAGO) VALOR, PP.DT_ALTERACAO DT_HORA ");
            sql.Append("FROM PAGAMENTO PG ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON (PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("JOIN PRODUTO PRO ON (PRO.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PRODUTO_PAI PPAI ON (PPAI.TIPO = PRO.TIPO) ");
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
            sql.Append("GROUP BY PPAI.TIPO, PRO.ID, PP.DESCRICAO, PP.DT_ALTERACAO, PG.VL_PAGO ");
            sql.Append("ORDER BY PPAI.TIPO ");

            //sql.Append("GROUP BY PPAI.TIPO, PRO.ID, PP.DESCRICAO, PP.DT_ALTERACAO ");
            //sql.Append("ORDER BY PPAI.TIPO ");

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
            sql.Append("FROM PRODUTO_PAI PPAI ");
            sql.Append("RIGHT JOIN PRODUTO PFILHO ON(PPAI.TIPO = PFILHO.TIPO) ");
            sql.Append("RIGHT JOIN PEDIDO_PRODUTO PP ON(PP.PRODUTO = PFILHO.ID) ");
            sql.Append("RIGHT JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("WHERE PP.SITUACAO = 3 AND convert(varchar, PP.DT_ALTERACAO, 103) = '" + pData + "' ");
            sql.Append("GROUP BY PPAI.DESCRICAO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT TP.DESCRICAO DESCRICAO, SUM(PG.VL_PAGO) VALOR, 2 TIPO ");
            sql.Append("FROM PRODUTO PFILHO ");
            sql.Append("JOIN PEDIDO_PRODUTO PP ON(PP.PRODUTO = PFILHO.ID) ");
            sql.Append("JOIN PAGAMENTO PG ON(PG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("JOIN TIPO_PAGAMENTO TP ON (TP.ID = PG.TIPO_PAGAMENTO) ");
            sql.Append("WHERE PP.SITUACAO = 3 AND convert(varchar, PP.DT_ALTERACAO, 103) = '" + pData + "' ");
            sql.Append("GROUP BY TP.DESCRICAO ");


            SqlCommand sqlc = new SqlCommand(sql.ToString());
            sqlc.CommandType = CommandType.Text;

            dt = conexao.executarSelect(sqlc, conn);
            conn.Close();


            return dt;
        }


    }
}
