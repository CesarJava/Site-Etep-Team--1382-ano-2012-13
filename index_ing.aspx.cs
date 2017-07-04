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
    string retorno="";
    BDMenuNoticia bdnot = new BDMenuNoticia();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();       
       
    }


    public string exibir_noticia(string idioma) 
    {
        DataTable tb = bdnot.PesquisarNoticia();

        retorno = "";
        try
        {
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                if (idioma.ToUpper() == "INGLES")
                {
                    retorno += "  <span onclick=\"PegandoValores(" + tb.Rows[i]["ID_NT"].ToString() + ")\" class=\"cabecalhoN1Sub\"> " + tb.Rows[i]["TITULO_NT"].ToString() + "  </span><br /> ";
                    retorno += "  <span onclick=\"PegandoValores(" + tb.Rows[i]["ID_NT"].ToString() + ")\" class=\"pLink\"><a> " + tb.Rows[i]["DESC_MEN_NT_ing"].ToString() + "</a></span><br />";
                }
                else
                {
                    retorno += "  <span onclick=\"PegandoValores(" + tb.Rows[i]["ID_NT"].ToString() + ")\" class=\"cabecalhoN1Sub\"> " + tb.Rows[i]["TITULO_NT"].ToString() + "  </span><br /> ";
                    retorno += "  <span onclick=\"PegandoValores(" + tb.Rows[i]["ID_NT"].ToString() + ")\" class=\"pLink\"><a> " + tb.Rows[i]["DESC_MEN_NT"].ToString() + "</a></span><br />";

                }
            }
        }
        catch { }

        return retorno;
    }

    public string exibir_progresso(string idioma)
    {
        DataTable tb = bdnot.PesquisarProgresso();

        retorno = "";
        try
        {
            for (int i = 0; i < tb.Rows.Count; i++)
            {

                if (idioma.ToUpper() == "INGLES")
                {
                    retorno += "  <span onclick=\"PegandoValores_prog(" + tb.Rows[i]["ID_PG"].ToString() + ")\" class=\"cabecalhoN1Sub\"> " + tb.Rows[i]["TITULO_PG"].ToString() + "  </span><br /> ";
                    retorno += "  <span onclick=\"PegandoValores_prog(" + tb.Rows[i]["ID_PG"].ToString() + ")\" class=\"pLink\"><a> " + tb.Rows[i]["DESC_MEN_PG_ing"].ToString() + "</a></span><br />";
                }
                else
                {
                    retorno += "  <span onclick=\"PegandoValores_prog(" + tb.Rows[i]["ID_PG"].ToString() + ")\" class=\"cabecalhoN1Sub\"> " + tb.Rows[i]["TITULO_PG"].ToString() + "  </span><br /> ";
                    retorno += "  <span onclick=\"PegandoValores_prog(" + tb.Rows[i]["ID_PG"].ToString() + ")\" class=\"pLink\"><a> " + tb.Rows[i]["DESC_MEN_PG"].ToString() + "</a></span><br />";

                }
            }
        }
        catch { }

        return retorno;
    }
}
