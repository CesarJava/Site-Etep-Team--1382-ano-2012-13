using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

public class Conexao
{

    public Conexao() { }

    static MySqlConnection conectar;

    public static MySqlConnection Conectar
    {
        get { return Conexao.conectar; }
        set { Conexao.conectar = value; }
    }

    public string criar_Conexao()
    {
        if (conectar != null)
        {
            conectar.Close();
        }



        string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=false", "127.0.0.1", "root", "2101994");

        //string configuracao = string.Format("server={0};userid={1};password={2};database=mysql;pooling=false", ip.Replace(',','.'), user, key);

        try
        {
            conectar = new MySqlConnection(configuracao);
            conectar.Open();
        }
        catch (MySqlException erro)
        {
            return ("Erro de acesso ao Banco: " + erro);
        }

        MySqlDataReader banco = null;
        MySqlCommand usar = new MySqlCommand("use etepteam1382", conectar);

        try
        {
            banco = usar.ExecuteReader();
        }
        catch (MySqlException erro)
        {
            return ("Erro de acesso ao Banco: " + erro);
        }

        finally
        {
            if (banco != null)
            {
                banco.Close();
            }
        }

        return "conexão ok";
    }
}