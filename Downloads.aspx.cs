using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class _Default : System.Web.UI.Page
{

    string retorno = "";
    BDDownload bddown = new BDDownload();
    BDTemporada bdtem = new BDTemporada();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }



    public String Selecionar(string idioma)
    {

        try
        {
            DataTable tb = bdtem.Pesquisar();

            for (int x = 0; x < tb.Rows.Count; x++)
            {

                retorno += "  <div  style=\" width: 750px;  float: left;  padding-left: 30px;  color: #666;\">  <h1 class=\"perfil\"> " + tb.Rows[x]["LEGENDA_TEM"].ToString() + " </h1></div>";

                DataTable down = bddown.Pesquisar(tb.Rows[x]["ID_TEM"].ToString());

                for (int i = 0; i < down.Rows.Count; i++)
                {


                    if (idioma.ToUpper() == "INGLES")
                    {
                        retorno += "<div style= \" float: left;  color: #666\" > ";
                        retorno += "<a style= \" float: left; color: #666; padding-left: 25px;  \" href=\" " + down.Rows[i]["CAMINHO_DOW"].ToString() + " \"> " + down.Rows[i]["DESC_DOW_ing"].ToString() + " </a>";
                        retorno += "</div> ";
                        retorno += "<br></br>";
                        retorno += "<div style= \" width: 750px; height: 30px; float: left;  color: #666\" >  <br></br> </div> ";
                    }
                    else
                    {
                        retorno += "<div style= \" float: left;  color: #666\" > ";
                        retorno += "<a style= \" float: left; color: #666; padding-left: 25px;  \" href=\" " + down.Rows[i]["CAMINHO_DOW"].ToString() + " \"> " + down.Rows[i]["DESC_DOW"].ToString() + " </a>";
                        retorno += "</div> ";
                        retorno += "<div style= \" width: 750px; height: 30px; float: left;  color: #666\" >  <br></br> </div> ";
                    }

                }
            }
        }
        catch { retorno = ""; }
        return retorno;
    }

}