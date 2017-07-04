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

    public String Selecionar()
    {

        try
        {
            retorno = "";
            retorno = "<div class=\"perfil\">";

            DataTable tb = bdtem.Pesquisar();
            BDAno dao_ano = new BDAno();

            for (int i = 0; i < tb.Rows.Count; i++)
            {

                retorno += "<div style=\" height: 100px; width: 200px;  float: left; \" >";
                try
                {
                    Session["ID_TEM"] = tb.Rows[i]["ID_TEM"].ToString();
                }
                catch{}
                retorno += "<img  name=\"" + tb.Rows[i]["ID_TEM"].ToString() + "\" style=\" cursor:pointer; \"  onclick=\"PegandoValores(" + tb.Rows[i]["ID_TEM"].ToString() + ")\" src=\"" + dao_ano.Pesquisar_imagem(Session["ID_TEM"].ToString()) + "\" alt=\"\" width= \"200\" height=\"100\"  title=\"" + tb.Rows[i]["LEGENDA_TEM"].ToString() + "\" /> ";
                retorno += "</div> ";

                retorno += "<div style=\"   height: 90px; padding-top: 10px;  float: left; \">";
                retorno += "<h2>" + dao_ano.Pesquisar_legenda(Session["ID_TEM"].ToString()) + "</h2>";
                retorno += "</div> ";

            }

            Session["ID_TEM"] = string.Empty;
            retorno += "</div> ";
        }
        catch { retorno = ""; }
        Session["ID_TEM"] = string.Empty;
        return retorno;
    }

  

 
}
