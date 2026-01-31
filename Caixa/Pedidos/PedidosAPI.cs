using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Caixa.SQL;
using System.Data;
using dal;
using System.Net.Http;
using Auxiliar;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Caixa.Pedidos
{
    internal class PedidosAPI
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

        public PedidosAPI()
        {
            Task.Run(async () => await TestaInternet()).Wait();

            if (!temInternet)
                return;

            var connStr = "Server=sh00082.hostgator.com.br;Database=hg640183_pedidosdb;Uid=hg640183_jujuba;Pwd=102030@Br;";

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
                            List<string> teste1, teste2 = new List<string>();
                            ExtrairDadosDoJson5(pedido.Json, out teste1, out teste2);

                            string condicaoBusca = TratarEInserirPedido(teste1, conn, transacao);

                            if (condicaoBusca != null)
                            {
                                // Buscar ID do pedido
                                var sql = new StringBuilder();
                                sql.Append("SELECT ID FROM PEDIDO WHERE DESCRICAO = @pCondicaoBusca");

                                using (var sqlc = new SqlCommand(sql.ToString(), conn, transacao))
                                {
                                    sqlc.CommandType = CommandType.Text;
                                    sqlc.Parameters.AddWithValue("@pCondicaoBusca", condicaoBusca);

                                    var dt = auxSQL.retornaDataTableTransaction(conn, sqlc);
                                    int pedidoInserido = int.Parse(dt.Rows[0]["ID"].ToString());

                                    // Monta blocos de itens
                                    var listaAtual = new List<string>();
                                    foreach (var linha in teste2)
                                    {
                                        if (linha.StartsWith("---------------------------"))
                                        {
                                            if (listaAtual.Count > 0)
                                            {
                                                TratarEInserirPedidoProduto(pedidoInserido, listaAtual, conn, transacao);
                                                listaAtual.Clear();
                                            }
                                        }
                                        else
                                        {
                                            listaAtual.Add(linha);
                                        }
                                    }
                                    if (listaAtual.Count > 0)
                                        TratarEInserirPedidoProduto(pedidoInserido, listaAtual, conn, transacao);
                                }

                                transacao.Commit();                 // commit só se tudo deu certo
                            }
                            else
                            { transacao.Rollback(); }

                            repo.MarcarComoProcessado(pedido.Id);
                        }
                        catch
                        {
                            transacao.Rollback();
                            throw;
                        }

                    } // transacao.Dispose()
                }     // conn.Dispose()

            }
        }
        private string GetValue(Dictionary<string, string> dict, string key, string defaultValue = "")
        {
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }
        
        //METODO COM ADIÇÃO AOS PICOLES
        public void TratarEInserirPedidoProduto(int pedidoID, List<string> lista2, SqlConnection pConexao, SqlTransaction pTransaction)
        {

            // Converte lista para dicionário
            var dados = new Dictionary<string, string>();
            foreach (var linha in lista2)
            {
                if (linha.Contains(":"))
                {
                    var partes = linha.Split(':');
                    string chave = partes[0].Trim().ToLower();
                    string valor = string.Join(":", partes.Skip(1)).Trim();
                    dados[chave] = valor;
                }
            }

            string nomeProduto = GetValue(dados, "name");
            string produto = GetValue(dados, "external_code");
            string amountStr = GetValue(dados, "amount", "1");

            double quantidade = 1;
            double.TryParse(amountStr, NumberStyles.Any, CultureInfo.InvariantCulture, out quantidade);

            string detalhesBruto = GetValue(dados, "detalhes");
            int situacao = 8;
            string obs = "";

            // ============================================
            //        🚨 LÓGICA ESPECIAL PARA PICOLÉS
            // ============================================
            if (nomeProduto.Equals("Picolés Opções", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrWhiteSpace(detalhesBruto))
                {
                    string t = detalhesBruto;

                    // Remove título inicial, caso venha
                    t = Regex.Replace(t, "Sabores de Picolés", "", RegexOptions.IgnoreCase).Trim();

                    // Normaliza vírgulas duplas
                    while (t.Contains(",,"))
                        t = t.Replace(",,", ",");

                    // Quebra em itens
                    var itensBrutos = t.Split(',')
                                       .Select(s => s.Trim())
                                       .Where(s => !string.IsNullOrWhiteSpace(s))
                                       .ToList();

                    foreach (var item in itensBrutos)
                    {
                        var match = Regex.Match(item, @"(\d+)\s*x\s*\|\s*(.+)", RegexOptions.IgnoreCase);

                        if (match.Success)
                        {
                            int qtd = int.Parse(match.Groups[1].Value);
                            string sabor = match.Groups[2].Value.Trim();

                            // Descobre ID do produto conforme o sabor
                            int produtoId;
                            string descricao = "";

                            if (sabor.Equals("brigadeiro", StringComparison.OrdinalIgnoreCase))
                            {
                                produtoId = 13;
                            }
                            else if (sabor.Equals("skimo", StringComparison.OrdinalIgnoreCase))
                            {
                                produtoId = 12;
                            }
                            else
                            {
                                produtoId = 11;
                                descricao = sabor.ToUpper(); // mantém acentos
                            }

                            // Faz um insert por sabor
                            StringBuilder sqlPicole = new StringBuilder();
                            sqlPicole.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) ");
                            sqlPicole.Append("VALUES (@pPedidoID, @pProduto, @pQuantidade, @pDescricao, @pSituacao, GETDATE(), @pObs)");

                            SqlCommand sqlcPicole = new SqlCommand(sqlPicole.ToString(), pConexao, pTransaction);
                            sqlcPicole.CommandType = CommandType.Text;
                            sqlcPicole.Parameters.AddWithValue("@pPedidoID", pedidoID);
                            sqlcPicole.Parameters.AddWithValue("@pProduto", produtoId);
                            sqlcPicole.Parameters.AddWithValue("@pQuantidade", qtd);
                            sqlcPicole.Parameters.AddWithValue("@pDescricao", descricao);
                            sqlcPicole.Parameters.AddWithValue("@pObs", obs);
                            sqlcPicole.Parameters.AddWithValue("@pSituacao", situacao);

                            auxSQL.executaQueryTransaction(pConexao, sqlcPicole);
                        }
                    }
                }

                return; // encerra aqui pois picolé já fez os inserts
            }



            // =============================================
            // NOVO TRECHO: Identificação dinâmica de blocos
            // =============================================
            List<string> saboresList = new List<string>();
            List<string> coberturasList = new List<string>();
            List<string> adicionaisList = new List<string>();

            if (!string.IsNullOrWhiteSpace(detalhesBruto))
            {
                string temp = detalhesBruto;

                // Remover duplicações de vírgula
                while (temp.Contains(",,"))
                    temp = temp.Replace(",,", ",");

                // Palavras-chave
                string[] chaves = new string[]
                {
        "Adicionais Pagos",
        "Sabores de Picolés",
        "Sabores (Máximo:",
        "Adicionais (Máximo:",
        "Coberturas (Máximo:"
                };

                // Criar dicionário de blocos -> AGORA COM CHAVE int
                Dictionary<int, string> blocos = new Dictionary<int, string>();

                foreach (var chave in chaves)
                {
                    int index = temp.IndexOf(chave, StringComparison.OrdinalIgnoreCase);
                    if (index >= 0)
                        blocos[index] = chave;
                }

                if (blocos.Count > 0)
                {
                    var ordenado = blocos.OrderBy(b => b.Key).ToList();

                    for (int i = 0; i < ordenado.Count; i++)
                    {
                        string chaveAtual = ordenado[i].Value;
                        int inicio = ordenado[i].Key + chaveAtual.Length;

                        int fim = (i < ordenado.Count - 1) ? ordenado[i + 1].Key : temp.Length;

                        // Extrair conteúdo do bloco
                        string conteudo = temp.Substring(inicio, fim - inicio).Trim();

                        var itens = conteudo.Split(',')
                            .Select(x => x.Trim())
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .ToList();

                        if (chaveAtual.StartsWith("Adicionais Pagos", StringComparison.OrdinalIgnoreCase))
                            adicionaisList.AddRange(itens);

                        else if (chaveAtual.StartsWith("Coberturas", StringComparison.OrdinalIgnoreCase))
                            coberturasList.AddRange(itens);

                        else if (chaveAtual.StartsWith("Sabores", StringComparison.OrdinalIgnoreCase))
                            saboresList.AddRange(itens);
                        
                        else if (chaveAtual.StartsWith("Adicionais (Máximo:", StringComparison.OrdinalIgnoreCase))
                                saboresList.AddRange(itens);
                    }
                }
            }



            // ============================================
            //     ✅ PROCESSAMENTO NORMAL (JÁ EXISTIA)
            // ============================================
            //string descricaoItens = "";

            //if (!string.IsNullOrWhiteSpace(detalhesBruto))
            //{
            //    string t = detalhesBruto;

            //    // Remove título opcional
            //    t = Regex.Replace(t, "Sabores \\(Máximo: 6\\)", "", RegexOptions.IgnoreCase).Trim();
            //    t = Regex.Replace(t, "Sabores \\(Máximo: 4\\)", "", RegexOptions.IgnoreCase).Trim();

            //    while (t.Contains(",,"))
            //        t = t.Replace(",,", ",");

            //    var itensBrutos = t.Split(',')
            //                       .Select(s => s.Trim())
            //                       .Where(s => !string.IsNullOrWhiteSpace(s))
            //                       .ToList();

            //    List<string> listaFinal = new List<string>();

            //    foreach (var item in itensBrutos)
            //    {
            //        var match = Regex.Match(item, @"(\d+)\s*x\s*\|\s*(.+)", RegexOptions.IgnoreCase);

            //        if (match.Success)
            //        {
            //            int qtd = int.Parse(match.Groups[1].Value);
            //            string sabor = match.Groups[2].Value.Trim();

            //            for (int i = 0; i < qtd; i++)
            //                listaFinal.Add(sabor);
            //        }
            //        else
            //        {
            //            listaFinal.Add(item);
            //        }
            //    }

            //    descricaoItens = string.Join(", ", listaFinal);
            //}


            // =============================================
            // MONTAÇÃO DA DESCRIÇÃO (Sabores + Coberturas)
            // =============================================
            string descricaoItens = "";

            List<string> saboresFormatados = new List<string>();
            foreach (var s in saboresList)
            {
                var m = Regex.Match(s, @"(\d+)\s*x\s*\|\s*(.+)", RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    int qtd = int.Parse(m.Groups[1].Value);
                    string nome = m.Groups[2].Value.Trim();
                    for (int i = 0; i < qtd; i++)
                        saboresFormatados.Add(nome);
                }
                else
                {
                    saboresFormatados.Add(s);
                }
            }

            // Monta a descrição final
            if (saboresFormatados.Count > 0)
            {
                descricaoItens = string.Join(", ", saboresFormatados).ToUpper();
            }

            if (coberturasList.Count > 0)
            {
                List<string> cobFormatadas = new List<string>();
                foreach (var c in coberturasList)
                {
                    var m2 = Regex.Match(c, @"(\d+)\s*x\s*\|\s*(.+)", RegexOptions.IgnoreCase);
                    if (m2.Success)
                        cobFormatadas.Add(m2.Groups[2].Value.Trim());
                    else
                        cobFormatadas.Add(c);
                }

                if (!string.IsNullOrWhiteSpace(descricaoItens))
                    descricaoItens += "; ";

                descricaoItens += "COB.: " + string.Join(", ", cobFormatadas).ToUpper();
            }


            //descricaoItens = descricaoItens.Replace(" |", "");
            //StringBuilder sql = new StringBuilder();
            //sql.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) ");
            //sql.Append("VALUES (@pPedidoID, @pProduto, @pQuantidade, UPPER(@pDescricao), @pSituacao, GETDATE(), UPPER(@pObs))");

            //SqlCommand sqlc = new SqlCommand(sql.ToString(), pConexao, pTransaction);
            //sqlc.CommandType = CommandType.Text;
            //sqlc.Parameters.AddWithValue("@pPedidoID", pedidoID);
            //sqlc.Parameters.AddWithValue("@pProduto", produto);
            //sqlc.Parameters.AddWithValue("@pQuantidade", quantidade);
            //sqlc.Parameters.AddWithValue("@pDescricao", descricaoItens);
            //sqlc.Parameters.AddWithValue("@pObs", obs);
            //sqlc.Parameters.AddWithValue("@pSituacao", situacao);

            //auxSQL.executaQueryTransaction(pConexao, sqlc);

            descricaoItens = descricaoItens.Replace(" |", "");
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO PEDIDO_PRODUTO (PEDIDO, PRODUTO, QT_PRODUTO, DESCRICAO, SITUACAO, DT_ALTERACAO, OBSERVACAO) ");
            sql.Append("VALUES (@pPedidoID, @pProduto, @pQuantidade, @pDescricao, @pSituacao, GETDATE(), @pObs); ");
            sql.Append("SELECT SCOPE_IDENTITY();");

            SqlCommand sqlc = new SqlCommand(sql.ToString(), pConexao, pTransaction);
            sqlc.CommandType = CommandType.Text;
            sqlc.Parameters.AddWithValue("@pPedidoID", pedidoID);
            sqlc.Parameters.AddWithValue("@pProduto", produto);
            sqlc.Parameters.AddWithValue("@pQuantidade", quantidade);
            sqlc.Parameters.AddWithValue("@pDescricao", descricaoItens);
            sqlc.Parameters.AddWithValue("@pObs", obs);
            sqlc.Parameters.AddWithValue("@pSituacao", situacao);

            // Executa e captura o ID do produto inserido
            int pedidoProdutoID = Convert.ToInt32(auxSQL.retornaValorScalarTransaction(pConexao, sqlc));



            // =============================================
            // INSERIR ADICIONAIS PAGOS (PEDIDO_PRODUTO_ADDS)
            // =============================================
            if (adicionaisList.Count > 0)
            {
                foreach (var add in adicionaisList)
                {
                    var mAdd = Regex.Match(add, @"(\d+)\s*x\s*\|\s*(.+)", RegexOptions.IgnoreCase);
                    int qtdAdd = 1;
                    string nomeAdd = add;

                    if (mAdd.Success)
                    {
                        qtdAdd = int.Parse(mAdd.Groups[1].Value);
                        nomeAdd = mAdd.Groups[2].Value.Trim().Replace(" |", "").Replace("|", "");
                    }

                    StringBuilder sqlAdd = new StringBuilder();
                    sqlAdd.Append("INSERT INTO PEDIDO_PRODUTO_ADDS (PEDIDO_PRODUTO, PRODUTO, DESCRICAO, QT_PRODUTO, DT_ALTERACAO) ");
                    sqlAdd.Append("VALUES (@pPedidoProduto, ISNULL((SELECT ID FROM PRODUTO WHERE DESCRICAO LIKE CONCAT('ADD ', UPPER(@pDesc))),0), @pDesc, @pQtd, GETDATE())");

                    SqlCommand sqlcAdd = new SqlCommand(sqlAdd.ToString(), pConexao, pTransaction);
                    sqlcAdd.CommandType = CommandType.Text;
                    sqlcAdd.Parameters.AddWithValue("@pPedidoProduto", pedidoProdutoID);
                    sqlcAdd.Parameters.AddWithValue("@pDesc", nomeAdd.ToUpper());
                    sqlcAdd.Parameters.AddWithValue("@pQtd", qtdAdd);

                    auxSQL.executaQueryTransaction(pConexao, sqlcAdd);
                }
            }


        }

        //public string RemoverAcentos(string texto)
        //{
        //    if (string.IsNullOrWhiteSpace(texto))
        //        return texto;

        //    var normalized = texto.Normalize(NormalizationForm.FormD);
        //    var sb = new StringBuilder();

        //    foreach (var c in normalized)
        //    {
        //        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
        //        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
        //            sb.Append(c);
        //    }

        //    return sb.ToString().Normalize(NormalizationForm.FormC);
        //}


        public string TratarEInserirPedido(List<string> lista1, SqlConnection pConexao, SqlTransaction pTransaction)
        {
            // Converter lista para dicionário
            var dados = new Dictionary<string, string>();
            foreach (var linha in lista1)
            {
                if (linha.Contains(":"))
                {
                    var partes = linha.Split(':');
                    string chave = partes[0].Trim().ToLower();
                    string valor = string.Join(":", partes.Skip(1)).Trim();
                    dados[chave] = valor;
                }
            }

            // ------ 1. Descrição ------
            string customerName = GetValue(dados, "customer_name");
            string customerPhone = GetValue(dados, "customer_phone_number");
            string customerCode = GetValue(dados, "code");
            string descricao = $"{customerName} {customerPhone} // {customerCode}".Trim();

            // ------ 3. Endereço ------
            string street = GetValue(dados, "street");
            string number = GetValue(dados, "number");
            string district = GetValue(dados, "district");
            string reference = GetValue(dados, "reference");


            // ------ 2. Tipo Pedido ------
            string tipoPedido = "2";
            if (street.Length > 0)// Tem endereço
                tipoPedido = "3";

            string endereco = $"{street}, Nº {number}, {district}".Trim().TrimEnd(',');
            if (!string.IsNullOrWhiteSpace(reference))
                endereco += $" (REFERÊNCIA: {reference})";
            if (endereco.Length < 10)
                endereco = "";

            // ------ 4. Observação ------
            var obsList = new List<string>();

            int exchanged = Convert.ToInt32(GetValue(dados, "exchanged", "0"));
            decimal priceExchanged = Convert.ToDecimal(GetValue(dados, "price_exchanged", "0").Replace(".",","));
            int paymentMethod = Convert.ToInt32(GetValue(dados, "payment_method", "0"));

            if (exchanged == 1)
                obsList.Add($"TROCO PARA R$ {priceExchanged:n2}");

            if (paymentMethod != 0 && paymentMethod != 2)
                obsList.Add("PAGAMENTO NO CARTÃO");

            if (paymentMethod == 0 && exchanged == 0)
                obsList.Add("DINHEIRO - NÃO PRECISA DE TROCO");

            if (paymentMethod == 2)
                obsList.Add("PAGAMENTO NO PIX");

            string observacao = string.Join(" ; ", obsList);

            // ------ 5. Inserido Por ------
            int inseridoPor = 3;
            if (tipoPedido == "2")
                descricao += " - VEM BUSCAR";

            // ------ 6. Chama seu método já existente ------
            //insertPedido(descricao, tipoPedido, 1, endereco, observacao, inseridoPor);

            StringBuilder sqlVerifica = new StringBuilder();
            sqlVerifica.Append("SELECT COUNT(1) FROM PEDIDO WHERE DESCRICAO = @pDescricao AND SITUACAO != 0");

            SqlCommand cmdVerifica = new SqlCommand(sqlVerifica.ToString(), pConexao, pTransaction);
            cmdVerifica.CommandType = CommandType.Text;
            cmdVerifica.Parameters.AddWithValue("@pDescricao", descricao);

            int existe = Convert.ToInt32(auxSQL.retornaValorScalarTransaction(pConexao, cmdVerifica));

            // Se existir, limpa a descrição
            if (existe > 0)
            {
                descricao = null;
            }
            else
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO PEDIDO (DESCRICAO, TIPO, SITUACAO, DT_INICIAL, ENDERECO, OBSERVACAO, INSERIDO_POR) VALUES ");
                sql.Append("(UPPER(@pDescricao), @pTipoPedido, @pSituacao, getdate(), @pEndereco, @pObservacao, @pInseridoPor)");

                SqlCommand sqlc = new SqlCommand(sql.ToString(), pConexao, pTransaction);
                sqlc.CommandType = CommandType.Text;
                sqlc.Parameters.AddWithValue("@pTipoPedido", tipoPedido);
                sqlc.Parameters.AddWithValue("@pDescricao", descricao);
                sqlc.Parameters.AddWithValue("@pSituacao", 1);
                sqlc.Parameters.AddWithValue("@pEndereco", endereco);
                sqlc.Parameters.AddWithValue("@pObservacao", observacao);
                sqlc.Parameters.AddWithValue("@pInseridoPor", inseridoPor);
                auxSQL.executaQueryTransaction(pConexao, sqlc);
            }

            return descricao;
        }


        public void ExtrairDadosDoJson5(string jsonBruto, out List<string> listaPedido, out List<string> listaItens)
        {
            listaPedido = new List<string>();
            listaItens = new List<string>();

            // --- Limpeza do JSON ---
            string json = jsonBruto
                .Replace("result=", "")
                .Trim();

            // Remove [] externos se existirem
            if (json.StartsWith("[") && json.EndsWith("]"))
                json = json.Substring(1, json.Length - 2);


            try
            {
                JToken firstToken = null;
                using (var sr = new StringReader(json))
                using (var reader = new JsonTextReader(sr) { SupportMultipleContent = true })
                {
                    while (reader.Read())
                    {
                        // pegar o primeiro objeto ou array encontrado
                        if (reader.TokenType == JsonToken.StartObject || reader.TokenType == JsonToken.StartArray)
                        {
                            firstToken = JToken.ReadFrom(reader);
                            break;
                        }
                    }
                }

                if (firstToken != null)
                {
                    // Substitui 'json' pela representação textual do primeiro token
                    // (usando Formatting.None para manter em uma única linha e evitar espaços estranhos)
                    json = firstToken.ToString(Formatting.None);
                }
                else
                {
                    // Se não encontrou token (ex: string vazia ou só texto inválido),
                    // aplicamos uma sanitização simples: trim + remover vírgulas finais e sequências ",]" ",}"
                    json = (json ?? string.Empty).Trim();
                    json = RemoveTrailingCommas(json);
                }
            }
            catch (JsonReaderException)
            {
                // Se algo deu errado na tentativa de leitura, fazemos sanitização conservadora
                json = (json ?? string.Empty).Trim();
                json = RemoveTrailingCommas(json);
            }

            // Função auxiliar local (pode mover para util se quiser)
            string RemoveTrailingCommas(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;

                // remove BOM se houver
                if (s.Length > 0 && s[0] == '\uFEFF') s = s.Substring(1);

                // remover vírgulas finais repetidamente
                s = s.Trim();
                while (s.EndsWith(","))
                {
                    s = s.Substring(0, s.Length - 1).TrimEnd();
                }

                // corrigir ocorrências problemáticas comuns
                s = s.Replace(",]", "]").Replace(",}", "}");

                return s;
            }


            // Converte para objeto dinâmico
            var root = Newtonsoft.Json.Linq.JObject.Parse(json);


            // ========== LISTA 1: DADOS DO PEDIDO ==========

            // Estes 2 campos vêm dentro de order_data
            string customerName = "";
            string customerPhone = "";

            var orderDataStrFix = root["order_data"]?.ToString();
            if (!string.IsNullOrWhiteSpace(orderDataStrFix))
            {
                var orderDataFix = Newtonsoft.Json.Linq.JObject.Parse(orderDataStrFix);
                customerName = orderDataFix["customer_name"]?.ToString() ?? "";
                customerPhone = orderDataFix["customer_phone_number"]?.ToString() ?? "";
            }

            // Estes permanecem na raiz
            string userClientPhone = root["user_client_phone_number"]?.ToString() ?? "";
            string code = root["code"]?.ToString() ?? "";
            string paymentMethod = root["payment_method"]?.ToString() ?? "";

            // Novos campos solicitados
            string exchanged = root["exchanged"]?.ToString() ?? "";
            string priceExchanged = root["price_exchanged"]?.ToString() ?? "";

            // Endereço (vem como string JSON contendo array)
            string street = "", number = "", district = "", reference = "";

            var deliveryRaw = root["delivery_address"]?.ToString();
            if (!string.IsNullOrWhiteSpace(deliveryRaw))
            {
                try
                {
                    var enderecoArray = Newtonsoft.Json.Linq.JArray.Parse(deliveryRaw);

                    if (enderecoArray != null && enderecoArray.Count > 0)
                    {
                        var end = enderecoArray[0];
                        street = end["street"]?.ToString() ?? "";
                        number = end["number"]?.ToString() ?? "";
                        district = end["district"]?.ToString() ?? "";
                        reference = end["reference"]?.ToString() ?? "";
                    }
                }
                catch { }
            }

            listaPedido.Add($"customer_name: {customerName}");
            listaPedido.Add($"customer_phone_number: {customerPhone}");
            listaPedido.Add($"user_client_phone_number: {userClientPhone}");
            listaPedido.Add($"code: {code}");
            listaPedido.Add($"street: {street}");
            listaPedido.Add($"number: {number}");
            listaPedido.Add($"district: {district}");
            listaPedido.Add($"reference: {reference}");
            listaPedido.Add($"payment_method: {paymentMethod}");
            listaPedido.Add($"exchanged: {exchanged}");
            listaPedido.Add($"price_exchanged: {priceExchanged}");

            // ========== LISTA 2: ITENS DO PEDIDO ==========
            var orderDataStr = root["order_data"]?.ToString();

            if (!string.IsNullOrWhiteSpace(orderDataStr))
            {
                var orderData = Newtonsoft.Json.Linq.JObject.Parse(orderDataStr);

                var cartArray = orderData["cart"] as Newtonsoft.Json.Linq.JArray;
                if (cartArray != null)
                {
                    foreach (var itemCart in cartArray)
                    {
                        var itemObj = itemCart["item"]?[0];

                        string nome = itemObj?["name"]?.ToString() ?? "";
                        string codExterno = itemObj?["external_code"]?.ToString() ?? "";
                        string qtd = itemCart["amount"]?.ToString() ?? "1";
                        string preco = itemCart["price"]?.ToString() ?? "0";
                        string precoUnit = itemCart["unit_price"]?.ToString() ?? "0";

                        // Detalhes (sabores, coberturas, etc)
                        string detalhes = itemCart["additionals_details_list_view"]?.ToString() ?? "";
                        if (!string.IsNullOrWhiteSpace(detalhes))
                        {
                            detalhes = detalhes.Replace("<b>", "")
                                               .Replace("</b>", "")
                                               .Replace("<hr>", " | ")
                                               .Replace("\n", " ")
                                               .Replace("  ", " ")
                                               .Trim();

                            detalhes = detalhes.Replace("1x | ", "1x | ").Replace(" 1x", ", 1x");
                        }

                        listaItens.Add($"name: {nome}");
                        listaItens.Add($"external_code: {codExterno}");
                        listaItens.Add($"amount: {qtd}");
                        listaItens.Add($"price: {preco}");
                        listaItens.Add($"unit_price: {precoUnit}");

                        if (!string.IsNullOrWhiteSpace(detalhes))
                            listaItens.Add($"detalhes: {detalhes}");

                        listaItens.Add("---------------------------");
                    }
                }
            }
        }
    }
}
