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

    BDMenuGaleria bdgal = new BDMenuGaleria();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }
  

      public String Selecionar(String idioma) 
      {

          try{
        int contador = 0;
         retorno = "";

       DataTable tb = bdgal.Pesquisar();


       for (int i = 0; i < tb.Rows.Count; i++ )
       {

           retorno += "    <div style=\"float: left;  margin-left: 50px; height: 30px; width: 650px; \"><br></br></div>";

           retorno += "<div class=\"cabecalhoN1\" style=\" font-size: 25px; font-weight: 700; color: #006; letter-spacing: 0px; line-height: 25pt;float: left; height: 35px; width: 470px; \">";
           retorno += "<span style=\" margin-right: 140px; float: right\"> " + tb.Rows[0]["LEGENDA_GAL_VID"].ToString() + "</span>";
           retorno += "</div>";
           retorno += "<div style=\"float: right;   height: 130px; width: 180px; \">";
           retorno += "<img alt=\"\" src=\" imagens/video.png \"  >       </img> ";
           retorno += "</div>";
           retorno += "<div style=\"float: left;   height: 65px; width: 470px; font-size: 17px; color: #000\" >";
           retorno += "<span style=\"margin-right: 20px; float: right\"> " + tb.Rows[0]["SITE_GAL_VID"].ToString() + " <a href=\" " + tb.Rows[0]["CAMINHO_GAL_VID"].ToString() + " \" target=\"_blank\"> Visualizar Vídeo </a> </span>";
           retorno += "</div>";

           retorno += "<div style=\"float: left;   height: 30px; width: 470px; font-size: 17px; color: #000\" >";
           retorno += "<hr style=\"float: left; margin-left: 50px; height: 5px; width: 300px;\" ></hr>";
           retorno += "</div>";
       }
          }catch{}


        return retorno;
        //return retorno.replace("ã", "&atilde;");
    }
}
