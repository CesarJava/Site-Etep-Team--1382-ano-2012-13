<%@ Page Language="C#" MasterPageFile="~/LayoutPage_ing.master" AutoEventWireup="true" CodeFile="ProgressoCompleto_ing.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     
                            <%
                                        String variavel = "0";

                                        variavel = Request.Params.Get("id_progresso");

                                        if ( variavel != null)
                                        {
                                            this.id_noticia(variavel);
                                        }

                            %>



                            <div style="width: 750px; height: auto; float: left">
                                <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 300px;"> <%= this.Selecionar_titulo()%> </span>
                            </div>
                            <div style="width: 750px; height: auto; float: left">
                                <hr style="float: left; margin-left: 50px; height: 5px; width: 650px" ></hr>
                            </div>
                            <div style="width: 750px; height: 30px; float: left">
                                <br></br><br></br>
                            </div>
                            <div style="width: 720px; height: auto; padding-left: 30px; float: left; color: #000; font-size: 17px;  ">

                                <div id="ConteudoChamadaFt" style="width: auto; height: auto;  float: left"> <img src=" <%= this.Selecionar_imagem() %> " alt="foto " title="foto " name="img1"  class="imgNoticias" id="img1" /></div>

                                <%= this.Selecionar_Conteudo("INGLES")%>

                            </div>
                             

</asp:Content>

  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

        
  </asp:Content>

