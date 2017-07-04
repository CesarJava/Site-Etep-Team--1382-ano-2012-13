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
public class BDRobo
{
    public BDRobo()
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



    public DataTable Pesquisar(String id_tem)
    {

        try
        {
            carregar_tabela("select * from ROBO  where ID_TEM = " + id_tem + "");


            return tabela_memoria;
        }
        catch
        {
            tabela_memoria = null;
            return tabela_memoria;
        }
    }
  
}
