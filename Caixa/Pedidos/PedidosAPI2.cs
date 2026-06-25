using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;
using dal;
using System.Net.Http;
using Auxiliar;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using Caixa.DataSet;
using System.Text.Json;
using static ClosedXML.Excel.XLPredefinedFormat;
using System.Security.Cryptography.Xml;
using Caixa.SQL;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI;

namespace Caixa.Pedidos
{
    internal class PedidosAPI2
    {
        private SqlConnection conn;
        private SqlTransaction transacao;
        private dal.Conexao conexao = new dal.Conexao();
        private SQL.SQL auxSQL = new SQL.SQL();
        private bool temInternet;
        public async Task TestaInternet()
        {
            temInternet = await NetHelper.TemInternetAsync();
        }

        public PedidosAPI2()
        {
            Task.Run(async () => await TestaInternet()).Wait();

            //DESCOMENTAR O CODIGO ABAIXO EM PRODUÇÃO
            if (!temInternet)
                return;

            var connStr = "Server=sh00082.hostgator.com.br;Database=hg640183_pedidosdb;Uid=hg640183_jujuba;Pwd=102030@Br;Connection Timeout=5;";

            var repo = new RepositorioPedidos(connStr);

            var pedidos = repo.ObterPedidosNaoProcessados();


            foreach (var pedido in pedidos)
            {
                if (pedido.Json == null)
                {
                    MessageBox.Show("Nenhum JSON encontrado");
                    return;
                }


                using (SqlConnection conn = conexao.retornaConexao())
                {
                    // Só abre se ainda não estiver aberta
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (SqlTransaction transacao = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        try
                        {
                            ProcessarPedidos(pedido.Json, conn, transacao);
                            repo.MarcarComoProcessado(pedido.Id);
                        }
                        catch (Exception err)
                        {
                            return;
                        }

                    }  //transacao.Dispose();
                }      //conn.Dispose();

            }
        }

        public void ProcessarPedidos(string json, SqlConnection pConexao, SqlTransaction pTransaction)
        {
            string pedidoDescricao, pedidoEndereco = "", pedidoProdutoDescricao="", pedidoProdutoObservacao;
            int pedidoProdutoID, pedidoTipo;
            List<string> listaPedidoProduto = new List<string>();

            json = json.Substring(7);
            var pedidos = System.Text.Json.JsonSerializer.Deserialize<List<PedidoAPI>>(json);

            if (pedidos == null)
                return;

            foreach (var pedido in pedidos)
            {
                var orderDoc = JsonDocument.Parse(pedido.order_data);
                


                var root = orderDoc.RootElement;

                //INFORMACOES DO PEDIDO
                string codigo = pedido.code; //PEDIDO.DESCRICAO
                string cliente = root.GetProperty("customer_name").GetString().ToString() ?? ""; //PEDIDO.DESCRICAO 
                string telefone = root.GetProperty("customer_phone_number").GetString() ?? ""; //PEDIDO.DESCRICAO
                string observacaoPedido = root.GetProperty("note").GetString() ?? ""; //PEDIDO.OBSERVACAO


                pedidoDescricao = $"{cliente} {telefone} // {codigo}".Trim();

                //INFORMAÇÕES DO ENDERECO
                string delivery_type = pedido.delivery_type.ToString();//PEDIDO.TIPO
                if (delivery_type.Equals("0"))
                {
                    var address = JsonDocument.Parse(pedido.delivery_address.Substring(1, pedido.delivery_address.Length - 2));
                    var endereco = address.RootElement;

                    string street = endereco.GetProperty("street").GetString() ?? "";//PEDIDO.ENDERECO
                    string numero = endereco.GetProperty("number").GetString() ?? "";//PEDIDO.ENDERECO
                    string bairro = endereco.GetProperty("district").GetString() ?? "";//PEDIDO.ENDERECO
                    string referencia = endereco.GetProperty("reference").GetString() ?? "";//PEDIDO.ENDERECO
                    string complemento = endereco.GetProperty("complement").GetString() ?? "";//PEDIDO.ENDERECO
                    
                    pedidoTipo = 3; //MUDANDO O TIPO DE PEDIDO PARA ENTREGAR
                    
                    pedidoEndereco = $"{street}, Nº {numero}, {bairro}".Trim().TrimEnd(',');//COLOCANDO AS INFORMACOES NA VARIAVEL QUE SERIA INSERIDA NO BANCO
                    if (!string.IsNullOrWhiteSpace(referencia))
                        pedidoEndereco += $" (REFERÊNCIA: {referencia})";
                    if (!string.IsNullOrWhiteSpace(complemento))
                        pedidoEndereco += $" (COMPLEMENTO: {complemento})";

                }
                else
                {
                    pedidoTipo = 2;//MUDANDO O TIPO DE PEDIDO PARA LEVAR
                    pedidoDescricao += " - VEM BUSCAR";
                }


                //TROCO OU CARTÃO
                if (pedido.exchanged > 0)
                    observacaoPedido += ($"TROCO PARA R$ {pedido.price_exchanged:n2}");

                if (pedido.payment_method != 0 && pedido.payment_method != 2)
                    observacaoPedido += "PAGAMENTO NO CARTÃO";

                if (pedido.payment_method == 0 && pedido.exchanged == 0)
                    observacaoPedido += "DINHEIRO - NÃO PRECISA DE TROCO";

                if (pedido.payment_method == 2)
                    observacaoPedido += "PAGAMENTO NO PIX";


                //SE EXISTIR REGISTRO, PULAMOS TUDO PARA EVITAR DUPLICACOES // DESCOMENTAR O CODIGO ABAIXO PARA PRODUCAO
                StringBuilder sqlBusca = new StringBuilder();
                sqlBusca.Append("SELECT ID FROM PEDIDO WHERE DESCRICAO = @pedidoDescricao");
                SqlCommand sqlRegExistente = new SqlCommand(sqlBusca.ToString(), pConexao, pTransaction);
                sqlRegExistente.Parameters.AddWithValue("@pedidoDescricao", pedidoDescricao.ToUpper());
                //if (auxSQL.retornaDataTableTransaction(pConexao, sqlRegExistente).Rows.Count > 0)
                //    return;



                //INSERIR PEDIDO
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO PEDIDO (DESCRICAO, TIPO, SITUACAO, DT_INICIAL, ENDERECO, OBSERVACAO, INSERIDO_POR) VALUES ");
                sql.Append("(UPPER(@pDescricao), @pTipoPedido, @pSituacao, getdate(), @pEndereco, @pObservacao, @pInseridoPor)");

                SqlCommand sqlcPedido = new SqlCommand(sql.ToString(), pConexao, pTransaction);
                sqlcPedido.CommandType = CommandType.Text;
                sqlcPedido.Parameters.AddWithValue("@pTipoPedido", pedidoTipo);
                sqlcPedido.Parameters.AddWithValue("@pDescricao", pedidoDescricao.ToUpper());
                sqlcPedido.Parameters.AddWithValue("@pSituacao", 1);
                sqlcPedido.Parameters.AddWithValue("@pEndereco", pedidoEndereco.ToUpper());
                sqlcPedido.Parameters.AddWithValue("@pObservacao", observacaoPedido.ToUpper());
                sqlcPedido.Parameters.AddWithValue("@pInseridoPor", 3);//INSERIDO POR 3 = DELIVERYPOP
                try
                {
                    //DESCOMENTAR A LINHA ABAIXO EM PRODUÇÃO
                    auxSQL.executaQueryTransaction(pConexao, sqlcPedido); 
                }
                catch (Exception ex)
                {
                    pTransaction.Rollback();
                    MessageBox.Show("Erro: " + ex.InnerException.Message, "Contate o suporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                foreach (var cartItem in root.GetProperty("cart").EnumerateArray())
                {
                    var produto = cartItem.GetProperty("item")[0];

                    string quantidade = cartItem.GetProperty("amount").GetString() ?? "1";//PEDIDO_PRODUTO.QT_PRODUTO
                    string observacaoItem = cartItem.GetProperty("note").GetString() ?? "";//PEDIDO_PRODUTO.OBSERVACAO
                    
                    string codExterno = produto.GetProperty("external_code").GetString() ?? "";//PRODUTO.ID

                    //MILKSHAKE SEM OBSERVAÇÃO JÁ AUTOMATICAMENTE A GENTE JOGA OVOMALTINE
                    if (codExterno.Equals("9") && observacaoItem.Length < 0)
                        observacaoItem = "OVOMALTINE";

                    // Adicionais
                    pedidoProdutoDescricao = "";
                    List<string> listAddPago = new List<string>();
                    List<int> listQtAdd = new List<int>();
                    string[] saboresPicoles = null;
                    if (cartItem.TryGetProperty("additionals", out var additionals))
                    {
                        foreach (var adicional in additionals.EnumerateArray())
                        {
                            string idAddDelivery = adicional.GetProperty("id").ToString();
                            string nomeAdicional = adicional.GetProperty("name").GetString() ?? "";
                            string price = adicional.GetProperty("price").GetString() ?? "";


                            //ACESSANDO A QUANTIDADE DE CADA ADICIONAL, VISTO  QUE ELES NAO FICAM JUNTO AO NOME E VALOR DO ADICIONAL
                            foreach (var adicionalQtd in cartItem.GetProperty("additionalsAmount").EnumerateArray())
                            {
                                string valor = adicionalQtd.GetString() ?? "";
                                if (price.Length > 0 && double.Parse(price) > 0)
                                {
                                    //codificação para adicionar adicionais
                                    int idAdicional = int.Parse(valor.Split('_')[0]);
                                    if (idAdicional == int.Parse(adicional.GetProperty("id").ToString()))
                                    {
                                        listAddPago.Add(nomeAdicional);
                                        int quantidadeT = int.Parse(valor.Split('_')[1]);
                                        listQtAdd.Add(quantidadeT);
                                    }
                                }
                                else
                                {
                                    int qtRepet = 0;
                                    if (idAddDelivery.Equals(valor.Split('_')[0]))
                                    {
                                        qtRepet = int.Parse(valor.Split('_')[1]);
                                    }
                                    for (int i = 0; i < qtRepet; i++)
                                        pedidoProdutoDescricao += $"{nomeAdicional}, ";
                                }
                            }
                        }

                        if (pedidoProdutoDescricao.Length > 0)
                        {
                            pedidoProdutoDescricao = pedidoProdutoDescricao.Substring(0, pedidoProdutoDescricao.Length - 2);
                            //ordernar a string
                            pedidoProdutoDescricao = string.Join(", ",
                                           pedidoProdutoDescricao
                                           .Split(',')
                                           .Select(x => x.Trim())
                                           .OrderBy(x => x));
                        }

                    }

                    

                    //AS INFORMAÇÕES DESTE CAMPO É NECESSÁRIA PARA FAZER A IMPLEMENTAÇÃO DA INSERÇÃO PARA PICOLES E SORVETES
                    string adicionalDetalhes ="";
                    if (cartItem.TryGetProperty("additionals_details_list_view", out var detalhe))
                    {
                        adicionalDetalhes = detalhe.GetString() ?? "";
                    }



                    //SQL ABAIXO É PARA BUSCAR SORVETES, COMO NO SISTEMA OS PARAMETROS DA DESCRIÇÃO SÃO TRATATOS DIFERENTE DO DELIVERYPOP
                    //DEVEMOS FAZER UMA IMPLEMENTAÇÃO DIFERENTE E TRATAMENTO ESPECIAL, IGUAL AOS PICOLES.
                    //APÓS VERIFICAMOS QUE É UM PRODUTO DO TIPO SORVETE, ENTÃO MUDAREMOS A DESCRIÇÃO PARA FICAR IGUAL AO DO NOSSO SISTEMA
                    StringBuilder sqlSorvetes = new StringBuilder();
                    sqlSorvetes.Append("SELECT * FROM PRODUTO WHERE TIPO IN (1,4) AND ID = @pCodExterno");
                    SqlCommand sqlcSorvetes = new SqlCommand(sqlSorvetes.ToString(), pConexao, pTransaction);
                    sqlcSorvetes.CommandType = CommandType.Text;
                    sqlcSorvetes.Parameters.AddWithValue("@pCodExterno", codExterno);
                    if (auxSQL.retornaDataTableTransaction(pConexao, sqlcSorvetes).Rows.Count > 0)
                    {
                        string detalhes = adicionalDetalhes;
                        pedidoProdutoDescricao = "";

                        // Divide pelos blocos
                        string[] blocos = detalhes.Split(new[] { "<hr>" },StringSplitOptions.None); ;

                        foreach (string bloco in blocos)
                        {
                            string tipo = "";

                            if (bloco.Contains("<b>Sabores"))
                                tipo = "SABOR";
                            else if (bloco.Contains("<b>Coberturas"))
                                tipo = "COBERTURA";

                            // Remove o HTML
                            string texto = Regex.Replace(bloco, "<.*?>", "");

                            // Remove o título
                            int pos = texto.IndexOf(')');
                            if (pos >= 0)
                                texto = texto.Substring(pos + 1);

                            string[] itens = texto.Split(',');

                            foreach (string item in itens)
                            {
                                string valor = item.Trim();

                                string[] partes = valor.Split('|');

                                if (partes.Length < 2)
                                    continue;

                                int qtRepet = int.Parse(
                                    Regex.Match(partes[0], @"\d+").Value);

                                string descricao = partes[1].Trim();

                                if (tipo.Equals("SABOR"))
                                {
                                    for (int i = 0; i < qtRepet; i++)
                                        pedidoProdutoDescricao += descricao + ", ";
                                }
                                else if (tipo.Equals("COBERTURA"))
                                {
                                    pedidoProdutoDescricao += "; COB.: ";
                                    for (int i = 0; i < qtRepet; i++)
                                        pedidoProdutoDescricao += descricao + ", ";
                                }

                            }

                            pedidoProdutoDescricao = pedidoProdutoDescricao.Substring(0, pedidoProdutoDescricao.Length - 2);
                        }


                    }


                    sqlBusca = new StringBuilder();
                    sqlBusca.Append("SELECT MAX(ID) id FROM PEDIDO WHERE SITUACAO != 0 AND DESCRICAO = @pedidoDescricao"); //BUSCANDO O ID QUE FOI INSERIDO
                    using (var sqlcPedProd = new SqlCommand(sqlBusca.ToString(), pConexao, pTransaction))
                    {
                        sqlcPedProd.CommandType = CommandType.Text;
                        sqlcPedProd.Parameters.AddWithValue("@pedidoDescricao", pedidoDescricao);

                        var dt = auxSQL.retornaDataTableTransaction(pConexao, sqlcPedProd);
                        int pedidoInserido = int.Parse(dt.Rows[0]["ID"].ToString());

                        StringBuilder sqlPedidoProduto = new StringBuilder();

                        if (adicionalDetalhes.Contains("Sabores de Picolés"))
                        {

                            int pos = adicionalDetalhes.IndexOf("</b>");

                            if (pos >= 0)
                            {
                                adicionalDetalhes = adicionalDetalhes.Substring(pos + 4);
                            }
                            saboresPicoles = adicionalDetalhes.Split(',');

                            sqlPedidoProduto.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) ");
                            sqlPedidoProduto.Append("VALUES (@pPedidoID, @pProduto, @pQuantidade, @pDescricao, @pSituacao, GETDATE(), @pObs)");
                            
                            for (int i = 0; i < saboresPicoles.Length; i++)
                            {
                                pedidoProdutoDescricao = "";
                                string[] partes = saboresPicoles[i].Trim().Split('|');
                                string saborPicole = partes[1].Trim();

                                int qtPicole = int.Parse(
                                    partes[0]
                                        .Replace("x", "")
                                        .Trim());

                                quantidade = qtPicole.ToString();

                                // Descobre ID do produto conforme o sabor
                                if (saborPicole.Equals("brigadeiro", StringComparison.OrdinalIgnoreCase))
                                {
                                    codExterno = "13";
                                }
                                else if (saborPicole.Equals("skimo", StringComparison.OrdinalIgnoreCase))
                                {
                                    codExterno = "12";
                                }
                                else if (saborPicole.Equals("Zero Açúcar - Morango", StringComparison.OrdinalIgnoreCase))
                                {
                                    codExterno = "2164";
                                }
                                else
                                {
                                    codExterno = "11";
                                    pedidoProdutoDescricao = saborPicole.ToUpper(); // mantém acentos
                                }

                                SqlCommand sqlcPedidoProduto = new SqlCommand(sqlPedidoProduto.ToString(), pConexao, pTransaction);
                                sqlcPedidoProduto.CommandType = CommandType.Text;
                                sqlcPedidoProduto.Parameters.AddWithValue("@pPedidoID", pedidoInserido);
                                sqlcPedidoProduto.Parameters.AddWithValue("@pProduto", codExterno);
                                sqlcPedidoProduto.Parameters.AddWithValue("@pQuantidade", quantidade);
                                sqlcPedidoProduto.Parameters.AddWithValue("@pDescricao", pedidoProdutoDescricao);
                                sqlcPedidoProduto.Parameters.AddWithValue("@pObs", observacaoItem.ToUpper());
                                sqlcPedidoProduto.Parameters.AddWithValue("@pSituacao", 8);//situacao = 8 ele já vai imprimir direto quando salvar no banco
                                auxSQL.executaQueryTransaction(pConexao, sqlcPedidoProduto);
                            }
                        }
                        else
                        {
                            sqlPedidoProduto.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) ");
                            sqlPedidoProduto.Append("VALUES (@pPedidoID, @pProduto, @pQuantidade, @pDescricao, @pSituacao, GETDATE(), @pObs)");
                            SqlCommand sqlcPedidoProduto = new SqlCommand(sqlPedidoProduto.ToString(), pConexao, pTransaction); 
                            sqlcPedidoProduto.CommandType = CommandType.Text;
                            sqlcPedidoProduto.Parameters.AddWithValue("@pPedidoID", pedidoInserido);
                            sqlcPedidoProduto.Parameters.AddWithValue("@pProduto", codExterno);
                            sqlcPedidoProduto.Parameters.AddWithValue("@pQuantidade", quantidade);
                            sqlcPedidoProduto.Parameters.AddWithValue("@pDescricao", pedidoProdutoDescricao.ToUpper());
                            sqlcPedidoProduto.Parameters.AddWithValue("@pObs", observacaoItem.ToUpper());
                            sqlcPedidoProduto.Parameters.AddWithValue("@pSituacao", 8);//situacao = 8 ele já vai imprimir direto quando salvar no banco
                            auxSQL.executaQueryTransaction(pConexao, sqlcPedidoProduto);
                        }


                        if (listAddPago.Count > 0)
                        {
                            StringBuilder sqlAdd = new StringBuilder();
                            sqlAdd.Append("INSERT INTO PEDIDO_PRODUTO_ADDS (PEDIDO_PRODUTO, PRODUTO, DESCRICAO, QT_PRODUTO, DT_ALTERACAO) ");
                            sqlAdd.Append("VALUES ((SELECT MAX(ID) FROM PEDIDO_PRODUTO WHERE PEDIDO = @pPedido AND PRODUTO = @pProduto), ISNULL((SELECT ID FROM PRODUTO WHERE DESCRICAO LIKE CONCAT('ADD ', UPPER(@pDesc))),0), @pDesc, @pQtd, GETDATE())");

                            for (int i =0; i < listAddPago.Count; i++)
                            {
                                SqlCommand sqlcAdd = new SqlCommand(sqlAdd.ToString(), pConexao, pTransaction);
                                sqlcAdd.CommandType = CommandType.Text;
                                sqlcAdd.Parameters.AddWithValue("@pPedido", pedidoInserido);
                                sqlcAdd.Parameters.AddWithValue("@pProduto", codExterno);
                                sqlcAdd.Parameters.AddWithValue("@pDesc", listAddPago[i]);
                                sqlcAdd.Parameters.AddWithValue("@pQtd", listQtAdd[i]);

                                auxSQL.executaQueryTransaction(pConexao, sqlcAdd);
                            }

                        }

                    }

                }
                pTransaction.Commit();




                //INFORMACOES PARA SALVAR NO BANCO DE DADOS
                pedidoDescricao = cliente + " " + telefone + " // " + pedido.code;
            }
        }

    }
}
