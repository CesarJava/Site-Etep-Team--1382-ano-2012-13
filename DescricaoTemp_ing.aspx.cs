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
    BDTemporada bdtem = new BDTemporada();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }



    public String Selecionar_titulo_id()
    {

        try
        {
            retorno = "";
            DataTable tb = bdtem.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[0]["LEGENDA_TEM"].ToString();
            }
        }
        catch { }

        return retorno;
    }

    public String Selecionar_imagem_id()
    {
        try
        {
            retorno = "";
            DataTable tb = bdtem.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[0]["IMAGEM_TEM"].ToString();
            }
        }
        catch { }


        return retorno;
    }

    public String SelecionarConteudo_id(string Idioma)
    {

        try
        {
            retorno = "";
            retorno = "<div class=\"perfil\" style=\"font-size: 17px;\" > ";

            DataTable tb = bdtem.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (Idioma == "INGLES")
                {
                    retorno += tb.Rows[0]["DESC_TEM_ing"].ToString();
                }
                else
                {
                    retorno += tb.Rows[0]["DESC_TEM"].ToString();
                }
            }
            retorno += "</div> ";
        }
        catch { }

        return retorno;
    }

    public String SelecionarArquivo_id(string idioma)
    {
        try
        {
            retorno = "";

            BDDownload bddown = new BDDownload();
            DataTable tb = bddown.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (idioma.ToUpper() == "INGLES")
                {
                    retorno += "<div style= \" float: left;  color: #666\" > ";
                    retorno += "<a style= \" float: left; color: #666; padding-left: 25px;  \" href=\" " + tb.Rows[i]["CAMINHO_DOW"].ToString() + " \"> " + tb.Rows[i]["DESC_DOW_ing"].ToString() + " </a>";
                    retorno += "</div> ";
                }
                else
                {
                    retorno += "<div style= \" float: left;  color: #666\" > ";
                    retorno += "<a style= \" float: left; color: #666; padding-left: 25px;  \" href=\" " + tb.Rows[i]["CAMINHO_DOW"].ToString() + " \"> " + tb.Rows[i]["DESC_DOW"].ToString() + " </a>";
                    retorno += "</div> ";
                }
            }
        }
        catch { }file:///I:\first\FIRST\FIRST\SpryAssets\

        return retorno;
    }

    public String SelecionarArquivo()
    {
        try
        {
            retorno = "";

            DataTable tb = bdtem.Pesquisar();

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += "<div style=\" float:  left;  margin-left: 50px;  width:  650px; height: 30px; \"> <br></br> </div>";
                retorno += "<div style=\" float:  left;  margin-left: 200px; width:  650px; height: auto; \">  <a  style\" color: orangered; \" href=\"  " + tb.Rows[i]["ARQUIVO_TEM"].ToString() + " \">  " + tb.Rows[i]["ARQUIVO_TEM"].ToString() + " </a> </div>";
                retorno += " <hr style=\" float:  left;  margin-left: 216px;  height: 5px;    width: 216px;\" ></hr> ";
            }
        }
        catch { }

        return retorno;
    }

   

    public void setID_TEM(string variavel)
    {
        Session["ID_TEM"] = variavel.ToString();
    }



    public String Selecionar_imagem_robo()
    {

        try
        {
            retorno = "";
            BDRobo bdrob = new BDRobo();
            DataTable tb = bdrob.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[i]["IMAGEM_ROB"].ToString();
            }
        }
        catch { }

        return retorno;
    }


    public String Selecionar_titulo_robo(String idioma)
    {
        try
        {
            retorno = "";
            BDRobo bdrob = new BDRobo();
            DataTable tb = bdrob.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += tb.Rows[0]["NOME_ROB"].ToString();

            }
        }
        catch { }

        return retorno;
    }

    public String Selecionar_Conteudo_robo(String idioma)
    {
        try
        {
            retorno = "";
            BDRobo bdrob = new BDRobo();
            DataTable tb = bdrob.Pesquisar(Session["ID_TEM"].ToString());

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (idioma.ToUpper() == "INGLES")
                {

                    retorno += tb.Rows[i]["DESC_ROB_ing"].ToString();

                }
                else
                {

                    retorno += tb.Rows[i]["DESC_ROB"].ToString();
                }

            }
        }
        catch { }

        return retorno;
    }
}

