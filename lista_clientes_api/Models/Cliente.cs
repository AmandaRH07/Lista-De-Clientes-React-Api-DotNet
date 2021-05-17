using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Cliente
{
    public Cliente()
    {
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }

    public static List<Cliente> Todos()
    {
        var lista = new List<Cliente>();

        SqlConnection conn = new SqlConnection(Conexao.Dados);
        conn.Open();

        SqlCommand cmd = new SqlCommand("select * FROM Clientes", conn);
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            lista.Add(new Cliente
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nome = reader["Nome"].ToString(),
                Telefone = reader["Telefone"].ToString(),
                Endereco = reader["Endereco"].ToString(),
            });
        }

        conn.Close();
        conn.Dispose();
        cmd.Dispose();
        return lista;
    }
}