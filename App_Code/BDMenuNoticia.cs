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
public class BDMenuNoticia
{
	public BDMenuNoticia()
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


    public DataTable PesquisarNoticia()
    {


        try
        {
            carregar_tabela("select * from MENU_NOTICIA men inner join NOTICIA noti on men.ID_NT = noti.ID_NT where noti.PRIMEIRAPAGINA_NT = 'SIM' ");


            return tabela_memoria;
        }
        catch {
             tabela_memoria = null;
            return tabela_memoria;
        }
    }

    public DataTable PesquisarProgresso()
    {


        try
        {
            carregar_tabela("select * from MENU_PROGRESSO men inner join PROGRESSO noti on men.ID_PG = noti.ID_PG where noti.PRIMEIRAPAGINA_PG = 'SIM'");


            return tabela_memoria;
        }
        catch
        {
            tabela_memoria = null;
            return tabela_memoria;
        }
    }
}
