﻿using System;
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

    BDNoticia bdnot = new BDNoticia();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conexao con = new Conexao();

        con.criar_Conexao();

    }

    public void id_noticia(string var)
    {
        Session["id_noticia"] = var;
    }



    public String Selecionar_imagem()
    {
        try
        {
            DataTable tb = bdnot.PesquisarNoticia(Session["id_noticia"].ToString());

            retorno = "";


            retorno += tb.Rows[0]["CAMINHO_NT"].ToString();

        }
        catch { }

        return retorno;
    }


    public String Selecionar_titulo()
    {
        try
        {
            DataTable tb = bdnot.PesquisarNoticia(Session["id_noticia"].ToString());

            retorno = "";

            retorno += tb.Rows[0]["TITULO_NT"].ToString();
        }
        catch { }

        return retorno;
    }

    public String Selecionar_Conteudo(String idioma)
    {
        try
        {
            DataTable tb = bdnot.PesquisarNoticia(Session["id_noticia"].ToString());

            retorno = "";


            if (idioma.ToUpper() == "INGLES")
            {
                retorno += tb.Rows[0]["TEXTO_NT_ing"].ToString();

            }
            else
            {
                retorno += tb.Rows[0]["TEXTO_NT"].ToString();
            }

        }
        catch { }

        return retorno;
    }

    public String Selecionar()
    {
        try
        {
            DataTable tb = bdnot.PesquisarNoticia(Session["id_noticia"].ToString());

            retorno = "";

            retorno += tb.Rows[0]["TITULO_NT"].ToString();
        }
        catch { }
        return retorno;
    }
}
