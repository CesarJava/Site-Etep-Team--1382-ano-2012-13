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
    BDAcaoSocial bdacao = new BDAcaoSocial();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }

    public String Selecionar( String idioma)
    {


        try
        {
            int contador = 0;
            retorno = "";

            DataTable tb = bdacao.Pesquisar(Session["id_chairman"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (idioma == "INGLES")
                {
                    retorno += tb.Rows[i]["TEXTO_CH_ing"].ToString() ;
                }
                else
                {
                    retorno += tb.Rows[i]["TEXTO_CH"].ToString() ;
                }
            }
        }
        catch { }

        return retorno;
    }

    public String Selecionar_imagem( )
    {

        try
        {
            int contador = 0;
            retorno = "";

            DataTable tb = bdacao.Pesquisar(Session["id_chairman"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[i]["CAMINHO_CH"].ToString();
            }
        }
        catch { }

        return retorno;
    }

    public String Selecionar_titulo( )
    {

        try
        {
            int contador = 0;
            retorno = "";

            DataTable tb = bdacao.Pesquisar(Session["id_chairman"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                retorno += tb.Rows[i]["LEGENDA_CH"].ToString() ;
            }
        }
        catch { }

        return retorno;
    }


    public void setID_CH(string id_chairman)
    {
        Session["id_chairman"] = id_chairman.ToString();
    }
}

