using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class PedidoBruto
{
    public int Id { get; set; }
    public string Json { get; set; }
    public DateTime RecebidoEm { get; set; }
}

public class RepositorioPedidos
{
    private readonly string _connectionString;

    public RepositorioPedidos(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<PedidoBruto> ObterPedidosNaoProcessados()
    {
        var pedidos = new List<PedidoBruto>();

        using (var conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT id, json, recebido_em FROM pedidos_brutos WHERE processado = 0 ORDER BY 1 LIMIT 1 ", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pedidos.Add(new PedidoBruto
                    {
                        Id = reader.GetInt32("id"),
                        Json = reader.GetString("json"),
                        RecebidoEm = reader.GetDateTime("recebido_em")
                    });
                }
            }
        }

        return pedidos;
    }

    public void MarcarComoProcessado(int id)
    {
        using (var conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("UPDATE pedidos_brutos SET processado = 1 WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}