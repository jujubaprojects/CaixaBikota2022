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
            sql.Append("SELECT DISTINCT PED.ID PEDIDO, PP.ID PED_PROD_ID, PED.DESCRICAO DESCRICAO, PP.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, CASE PP.SITUACAO WHEN 0 THEN 0 ELSE P.VALOR END AS VL_PRODUTO, PP.QT_PRODUTO, SUM(PG.VL_PAGO) VL_PAGO  ");
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
                sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");

            }
            sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData ");
            //sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO ");
            sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO, PP.SITUACAO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT PED.ID, PED_ADD.PEDIDO_PRODUTO PED_PROD_ID, PED.DESCRICAO DESCRICAO, PED_ADD.DESCRICAO PED_DESCRICAO, convert(varchar, DT_INICIAL, 24) HORA, P2.VALOR VL_PRODUTO, ");
            sql.Append("PED_ADD.QT_PRODUTO, 0 VL_PAGO ");
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
                sql.Append("WHERE PP.SITUACAO != 0  AND PED.SITUACAO IN (@pSituacao) ");
                if (pTipo > 0)
                    sql.Append("AND PED.TIPO = @pTipo ");
            }
            sql.Append("AND convert(varchar, DT_INICIAL, 103) = @pData ");
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
            sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN(1, 2, 3, 4) AND convert(varchar, PED.DT_INICIAL, 103) = convert(varchar, getdate(), 103) ");
            sql.Append("GROUP BY PED.ID, PP.ID, PED.DESCRICAO, PP.DESCRICAO, DT_INICIAL, P.VALOR, PP.QT_PRODUTO ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT PED.ID, PP.ID AS PED_PROD, P2.VALOR VL_PRODUTO, PED_ADD.QT_PRODUTO, 0 VL_PAGO ");
            sql.Append("FROM PEDIDO PED ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED.ID = PP.PEDIDO) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO_ADDS PED_ADD ON(PP.ID = PED_ADD.PEDIDO_PRODUTO) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(PED_ADD.PRODUTO = P2.ID) ");
            sql.Append("WHERE  PP.SITUACAO != 0  AND PED.SITUACAO IN(1, 2, 3, 4) AND convert(varchar, PED.DT_INICIAL, 103) = convert(varchar, getdate(), 103) ");
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
            sql.Append("INSERT INTO PEDIDO (DESCRICAO, TIPO, SITUACAO) VALUES ( ");
            //sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao)");
            sql.Append("UPPER(@pDescricao), (SELECT ID FROM TIPO_PEDIDO WHERE DESCRICAO = @pTipoPedido), @pSituacao)");

            return sql.ToString();
        }
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

        public DataTable buscaCliente(int pID)
        {
            string sql = queryBuscaCliente(pID);

            SqlConnection conn = conexao.retornaConexao();

            SqlCommand sqlc = new SqlCommand(sql);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pID", pID);

            return conexao.executarSelect(sqlc, conn);
        }
        private string queryBuscaCliente(int pID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ID, NOME, ENDERECO, CONTATO, STATUS ");
            sql.Append("FROM CLIENTE ");
            if (pID > 0)
                sql.Append("WHERE ID = @pID");

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
            sql.Append("SELECT PP.ID AS PED_PROD_ID, NULL PRODUTO, NULL DESC_PRODUTO, PED_ADD.QT_PRODUTO, P2.VALOR VL_PRODUTO, (PED_ADD.QT_PRODUTO * P2.VALOR) VL_TOTAL, 0  VL_PAGO, ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 3 ");
            sql.Append(" WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) = (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM, @pCheckBox CHKDIVIDIR ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PP.ID IN(" + pPedidos + ") ");
            sql.Append("GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO ");
            sql.Append(") AUX ");
            sql.Append("LEFT JOIN PEDIDO_PRODUTO PP ON(PP.ID = AUX.PED_PROD_ID) ");
            sql.Append("LEFT JOIN PRODUTO P ON(P.ID = PP.PRODUTO) ");
            sql.Append("GROUP BY AUX.PED_PROD_ID, AUX.QT_PRODUTO, P.DESCRICAO, PP.DESCRICAO, AUX.CHKDIVIDIR ");

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
            sql.Append(" WHERE SITUACAO IN(1, 2) AND PEDIDO =  @pPedidoID ");
            sql.Append("GROUP BY PP.ID, P.VALOR, P.DESCRICAO, PP.DESCRICAO, PP.QT_PRODUTO ");
            sql.Append(" UNION ALL ");
            sql.Append("SELECT PP.ID AS PED_PROD_ID, NULL PRODUTO, NULL DESC_PRODUTO, PED_ADD.QT_PRODUTO, P2.VALOR VL_PRODUTO, (PED_ADD.QT_PRODUTO * P2.VALOR) VL_TOTAL, ");
            sql.Append("0  VL_PAGO /*, (PED_ADD.QT_PRODUTO * P2.VALOR) - (SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*)) VL_ABERTO*/,  ");
            sql.Append("CASE WHEN SUM(Coalesce(PAG.VL_PAGO, 0)) / COUNT(*) > (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 3 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) = (PED_ADD.QT_PRODUTO * P2.VALOR) THEN 4 ");
            sql.Append("WHEN SUM(Coalesce(PAG.VL_PAGO, 0))/ COUNT(*) > 0 THEN 2 ELSE 1 END ORDEM ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED_ADD ");
            sql.Append(" LEFT JOIN PEDIDO_PRODUTO PP ON(PED_ADD.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PAGAMENTO PAG ON(PAG.PEDIDO_PRODUTO = PP.ID) ");
            sql.Append("LEFT JOIN PRODUTO P2 ON(P2.ID = PED_ADD.PRODUTO) ");
            sql.Append("WHERE SITUACAO IN(1, 2) AND PEDIDO =  @pPedidoID ");
            sql.Append(" GROUP BY PP.ID, PED_ADD.DESCRICAO, PP.QT_PRODUTO, P2.DESCRICAO, P2.VALOR, PED_ADD.QT_PRODUTO ");
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

            sql.Append("SELECT PP.ID ID_PEDIDO_PRODUTO, PRO.ID ID_PRODUTO, PRO.DESCRICAO PRODUTO, PP.DESCRICAO, ");
            //sql.Append("CASE WHEN PP.TIPO = 1 THEN 'CONSUMIR' WHEN PP.TIPO = 2 THEN 'LEVAR' WHEN PP.TIPO = 3 THEN 'ENTREGAR' END TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            sql.Append("NULL TIPO, PP.QT_PRODUTO QUANTIDADE, ");
            sql.Append("(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
            sql.Append("WHERE PP.SITUACAO = 1 AND PED.ID = @pPedidoID ");
            sql.Append("UNION ALL ");
            sql.Append("SELECT NULL, NULL, 'VL. TOTAL', NULL, NULL, SUM(PP.QT_PRODUTO) QUANTIDADE, SUM(PP.QT_PRODUTO * PRO.VALOR) VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO PP ");
            sql.Append("LEFT JOIN PRODUTO PRO ON(PP.PRODUTO = PRO.ID) ");
            sql.Append("LEFT JOIN PEDIDO PED ON(PP.PEDIDO = PED.ID) ");
            sql.Append("LEFT JOIN CATEGORIA PPAI ON(PRO.TIPO = PPAI.TIPO) ");
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

            sql.Append("SELECT PED.ID, PED.DESCRICAO DESCRICAO, (SELECT DESCRICAO FROM TIPO_PEDIDO WHERE ID =  PED.TIPO) TIPO, ");
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

        public DataTable retornaTeste()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CONCAT(PED.ID, ' - ',PED.DESCRICAO, ' - ', COALESCE(CONCAT(CONVERT(VARCHAR, PP.DT_ALTERACAO, 103), ' ', CONVERT(VARCHAR, PP.DT_ALTERACAO, 108)), NULL)) DESC_PEDIDO, PED.TIPO, PED.ENDERECO, PED.OBSERVACAO OBS_PED, PP.ID PED_PROD_ID, ");
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
            sql.Append("SELECT PED.ID, PED.PEDIDO_PRODUTO, P.DESCRICAO PRODUTO, PED.DESCRICAO, PED.QT_PRODUTO, PED.DT_ALTERACAO, PED.QT_PRODUTO * P.VALOR AS VALOR ");
            sql.Append("FROM PEDIDO_PRODUTO_ADDS PED ");
            sql.Append("JOIN PRODUTO P ON(PED.PRODUTO = P.ID) ");
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
            sql.Append("UNION ALL ");
            sql.Append("SELECT DESCRICAO, VALOR, 3 TIPO ");
            sql.Append("FROM RETIRADA_CAIXA ");
            sql.Append("WHERE convert(varchar, DATA, 103) = '" + pData + "' ");



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
