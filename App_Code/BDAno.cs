using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for BDMenuNoticia
/// </summary>
public class BDAno
{
    public BDAno()
	{		
	}

    #region variaveis do MYSQL
    MySqlDataAdapter comando_sql;
    MySqlCommandBuilder executar_comando;
    DataTable tabela_memoria;

    #endregion

    private void carregar_tabela(string comando)
    {
        tabela_memoria = new DataTable();
        comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);
        executar_comando = new MySqlCommandBuilder(comando_sql);
        comando_sql.Fill(tabela_memoria);
    }


    public String Pesquisar_legenda(string id_temp)
    {

        try
        {
            carregar_tabela("select * from ANO ano inner join SEMANA sem on sem.ID_ANO = ano.ID_ANO inner join TEMPORADA temp on temp.ID_SEM = sem.ID_SEM where temp.ID_TEM=" + id_temp + " ");


            return tabela_memoria.Rows[0]["LEGENDA_ANO"].ToString();
        }
        catch {
             
            return string.Empty;
        }
    }



    public String Pesquisar_imagem(string id_temp)
    {

        try
        {
            carregar_tabela("select * from ANO ano inner join SEMANA sem on sem.ID_ANO = ano.ID_ANO inner join TEMPORADA temp on temp.ID_SEM = sem.ID_SEM where temp.ID_TEM=" + id_temp + "");


            return tabela_memoria.Rows[0]["IMAGEM_ANO"].ToString();
        }
        catch
        {
            return string.Empty;
        }
    }
  
}
