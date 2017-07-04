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
    BDEquipe bdeq = new BDEquipe();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }


    public String Selecionar( String idioma)
    {
        try
        {

            retorno = "<div class=\"perfil\">";
            String empt = "\"\"";

            DataTable tb = bdeq.Pesquisar(Session["id_equipe"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (idioma == "INGLES")
                {
                    retorno += tb.Rows[i]["TEXTO_EQ_ing"].ToString()  + " <br />";
                }
                else
                {
                    retorno += tb.Rows[i]["TEXTO_EQ"].ToString() + "<br />";
                }
            }


            retorno += "</div>";


        }
        catch { }
        return retorno;
    }

    public String Selecionar_imagem()
    {

        try
        {
            retorno = "";


            DataTable tb = bdeq.Pesquisar(Session["id_equipe"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[i]["CAMINHO_EQ"].ToString();
            }


        }
        catch { }
        return retorno;
    }

    public String Selecionar_titulo()
    {
        try
        {
            retorno = "";

            DataTable tb = bdeq.Pesquisar(Session["id_equipe"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                retorno += tb.Rows[i]["LEGENDA_EQ"].ToString();
            }
        }
        catch { }
        return retorno;

    }



    public void setID_EQ(string variavel)
    {
        Session["id_equipe"] = variavel.ToString();
    }
}
