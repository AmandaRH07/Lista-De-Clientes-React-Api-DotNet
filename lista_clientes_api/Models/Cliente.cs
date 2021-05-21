using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

[Table("Clientes")]
public class Cliente
{
    private static DbContexto db = new DbContexto();
    public Cliente() { }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }

    public Cliente Salvar()
    {
        if(this.Id > 0)
        {
            db.Clientes.Update(this);
        }
        else
        {
            db.Clientes.Add(this);
        }
        db.SaveChanges();
        return this;
    }

    public static List<Cliente> Todos()
    {
        return db.Clientes.ToList();
    }

    public static List<Cliente> Todos_Com_SqlConnection()
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
                Endereco = reader["Endereco"].ToString(),
                Telefone = reader["Telefone"].ToString(),
            });
        }

        conn.Close();
        conn.Dispose();
        cmd.Dispose();
        return lista;
    }

    public Cliente Salvar_Com_SqlConnection()
    {

        SqlConnection conn = new SqlConnection(Conexao.Dados);
        conn.Open();

        //prodecure
        SqlCommand cmd = new SqlCommand("CriarCliente @nome, @endereco, @telefone", conn);
        cmd.Parameters.Add("@nome", SqlDbType.VarChar);
        cmd.Parameters["@nome"].Value = this.Nome;

        cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
        cmd.Parameters["@endereco"].Value = this.Endereco;

        cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
        cmd.Parameters["@telefone"].Value = this.Telefone;

        this.Id = Convert.ToInt32(cmd.ExecuteScalar());

        conn.Close();
        return this;
    }
}
