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
    BDMenuChairman bdcha = new BDMenuChairman();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }

    public String Selecionar(String idioma)
    {
        try
        {
            int contador = 0;
             retorno = "";

            DataTable tb = bdcha.Pesquisar();

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                contador = contador + 1;
                retorno += "<div style=\"height: 200px; width: 150px;  float: left; \" >";
                retorno += "<img  name=\"" + tb.Rows[i]["ID_CH"].ToString() + "\" style=\" cursor:pointer; \" onclick=\"PegandoValores(" + tb.Rows[i]["ID_CH"].ToString() + ")\" src=\"" + tb.Rows[i]["CAMINHO_MEN_CH"].ToString() + "\" alt=\"\" width= \"120\" height=\"180\"  title=\"" + tb.Rows[i]["LEGENDA_MEN_CH"].ToString() + "\" /> ";
                retorno += "</div> ";

                retorno += "<div style=\"height: 50px; width: 150px;  float: left; \">";
                retorno += "<h2>" + tb.Rows[i]["LEGENDA_MEN_CH"].ToString() + "</h2>";
                retorno += "</div> ";

                retorno += "<div style=\"height: 150px; width: 150px;   float: left; \">";
                if (idioma == "INGLES")
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_CH_ing"].ToString() + " </h4>";
                }
                else
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_CH"].ToString() + "</h4>";
                }

                retorno += "</div> ";



                retorno += "<div> <br></br></div>  ";

            }
        }
        catch { }

        return retorno;
        //return retorno.replace("ã", "&atilde;");
    }
}

