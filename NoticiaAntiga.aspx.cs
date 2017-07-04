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

public partial class _NoticiaAntiga : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id_noticia"] == null)
        {
            Pesquisar_tudo();
        }
        else 
        {
            if (Session["id_noticia"].ToString() == string.Empty)
            {
                Pesquisar_tudo();
            }
            else 
            {
            
            }
        }
    }
    public string Pesquisar_tudo() 
    {
        return "";
    
    
    }

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        LinkButton lk = new LinkButton();
        lk = (LinkButton)(sender as object);
        Session["id_noticia"] = lk.ID.ToString();

    }
}
