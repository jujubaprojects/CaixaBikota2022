using Caixa.DataSet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.Json;


namespace Caixa
{


    public partial class frmTesteAPI : Form
    {
        public frmTesteAPI()
        {
            InitializeComponent();


            var connStr = "Server=localhost;Database=pedidosdb;Uid=root;Pwd=;";

            var repo = new RepositorioPedidos(connStr);

            var pedidos = repo.ObterPedidosNaoProcessados();

            foreach (var pedido in pedidos)
            {
                txtTest.Text += ($"ID: {pedido.Id}");
                txtTest.Text += ($"Recebido: {pedido.RecebidoEm}");

                if (pedido.Json == null)
                {
                    MessageBox.Show("Nenhum JSON encontrado");
                    return;
                }

                List<string> teste1, teste2 = new List<string>();
                ExtrairDadosDoJson5(pedido.Json, out teste1, out teste2);
                TratarEInserirPedido(teste1);

                repo.MarcarComoProcessado(pedido.Id); // Marca como importado
            }
        }

        private string GetValue(Dictionary<string, string> dict, string key, string defaultValue = "")
        {
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public void TratarEInserirPedido(List<string> lista1)
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
            string descricao = $"{customerName} {customerPhone}".Trim();

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

            // ------ 4. Observação ------
            var obsList = new List<string>();

            int exchanged = Convert.ToInt32(GetValue(dados, "exchanged", "0"));
            decimal priceExchanged = Convert.ToDecimal(GetValue(dados, "price_exchanged", "0"));
            int paymentMethod = Convert.ToInt32(GetValue(dados, "payment_method", "0"));

            if (exchanged == 1)
                obsList.Add($"PRECISA DE TROCO PARA R$ {priceExchanged:n2}");

            if (paymentMethod != 0)
                obsList.Add("PAGAMENTO NO CARTÃO");

            if (paymentMethod == 0 && exchanged == 0)
                obsList.Add("NÃO PRECISA DE TROCO");

            string observacao = string.Join(" ; ", obsList);

            // ------ 5. Inserido Por ------
            int inseridoPor = 3;
            if (tipoPedido == "2")
                descricao += " - VEM BUSCAR";

            // ------ 6. Chama seu método já existente ------
            //insertPedido(descricao, tipoPedido, 1, endereco, observacao, inseridoPor);
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




        public DeliveryPopOrder ObterPedidoDoBanco(int idPedido)
        {
            string json;
            var pedidoObj = new DeliveryPopOrder();

            string connectionString = "Server=localhost;Database=pedidosdb;Uid=root;Pwd=;";

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT json FROM pedidos_brutos WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPedido);
                    json = cmd.ExecuteScalar()?.ToString();
                }
            }

            if (json == null)
                throw new Exception("Nenhum registro encontrado com esse ID.");

            // Remove prefixo "result="
            if (json.StartsWith("result="))
                json = json.Replace("result=", "");

            // Remove [ ] do array
            json = json.Trim();
            if (json.StartsWith("[") && json.EndsWith("]"))
                json = json.Substring(1, json.Length - 2);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            // 1️⃣ Primeiro desserializamos somente o JSON externo
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;

                pedidoObj.Id = root.GetProperty("id").GetInt32();
                pedidoObj.User_Company_Id = root.GetProperty("user_company_id").GetInt32();
                pedidoObj.Company_Id = root.GetProperty("company_id").GetInt32();
                pedidoObj.Code = root.GetProperty("code").GetString();
                pedidoObj.Price_Total = root.GetProperty("price_total").GetString();

                // 2️⃣ order_data é um JSON dentro de uma string → precisamos desserializar agora
                string orderDataStr = root.GetProperty("order_data").GetString();

                // orderDataStr ainda vem com barras invertidas, então removemos
                orderDataStr = orderDataStr.Replace("\\\"", "\"").Replace("\\\\", "\\");

                pedidoObj.Order_Data = JsonSerializer.Deserialize<OrderData>(orderDataStr, options);

                // 3️⃣ delivery_address também é string contendo JSON
                string deliveryAddressStr = root.GetProperty("delivery_address").GetString();
                deliveryAddressStr = deliveryAddressStr.Replace("\\\"", "\"").Replace("\\\\", "\\");

                pedidoObj.Delivery_Address = JsonSerializer.Deserialize<List<DeliveryAddress>>(deliveryAddressStr, options);
            }

            return pedidoObj;
        }

    }
}
