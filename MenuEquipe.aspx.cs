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
    BDMenuEquipe bdeq = new BDMenuEquipe();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }


    public String SelecionarAluno(String idioma)
    {


        try
        {

            int contador = 0;
            retorno = "";

            DataTable tb = bdeq.Pesquisar("NAO");



            for (int i = 0; i < tb.Rows.Count; i++)
            {
                contador = contador + 1;
                retorno += "<div style=\"height: 295px; width: 150px; padding-top: 20px; padding-left: 30px; float: left; \" >";
                retorno += "<div style=\"height: 75px; width: 150px;  float: left; \">";
                retorno += "<h2>" + tb.Rows[i]["LEGENDA_MEN_EQ"].ToString() + "</h2>";
                retorno += "</div> ";
                retorno += "<div style=\"height: 180px; width: 150px;   float: left; \">";
                retorno += "<img  name=\"" + tb.Rows[i]["ID_EQ"].ToString() + "\"  style=\" cursor:pointer; \"  onclick=\"PegandoValores(" + tb.Rows[i]["ID_EQ"].ToString() + ")\" src=\"" + tb.Rows[i]["CAMINHO_MEN_EQ"].ToString() + "\" alt=\"\" width= \"120\" height=\"180\"  title=\"" + tb.Rows[i]["LEGENDA_MEN_EQ"].ToString() + "\" /> ";

                if (idioma == "INGLES")
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_EQ_ing"].ToString() + " </h4>";
                }
                else
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_EQ"].ToString() + "</h4>";
                }
                retorno += "</div> ";
                retorno += "</div> ";

                if (contador == 6)
                {
                    contador = 0;
                    retorno += " <br></br>  ";
                }
            }
        }
        catch { }


        return retorno;
    }

    public String SelecionarMentor(String idioma)
    {

        try
        {

            int contador = 0;
            retorno = "";

            DataTable tb = bdeq.Pesquisar("SIM");



            for (int i = 0; i < tb.Rows.Count; i++)
            {
                contador = contador + 1;
                retorno += "<div style=\"height: 295px; width: 150px; padding-top: 20px; padding-left: 30px; float: left; \" >";
                retorno += "<div style=\"height: 75px; width: 150px;  float: left; \">";
                retorno += "<h2>" + tb.Rows[i]["LEGENDA_MEN_EQ"].ToString() + "</h2>";
                retorno += "</div> ";
                retorno += "<div style=\"height: 180px; width: 150px;   float: left; \">";
                retorno += "<img  name=\"" + tb.Rows[i]["ID_EQ"].ToString() + "\"  style=\" cursor:pointer; \"  onclick=\"PegandoValores(" + tb.Rows[i]["ID_EQ"].ToString() + ")\" src=\"" + tb.Rows[i]["CAMINHO_MEN_EQ"].ToString() + "\" alt=\"\" width= \"120\" height=\"180\"  title=\"" + tb.Rows[i]["LEGENDA_MEN_EQ"].ToString() + "\" /> ";

                if (idioma == "INGLES")
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_EQ_ing"].ToString() + " </h4>";
                }
                else
                {
                    retorno += "<h4>" + tb.Rows[i]["DESC_MEN_EQ"].ToString() + "</h4>";
                }
                retorno += "</div> ";
                retorno += "</div> ";

                if (contador == 6)
                {
                    contador = 0;
                    retorno += " <br></br>  ";
                }
            }
        }
        catch { }


        return retorno;
    }
}
