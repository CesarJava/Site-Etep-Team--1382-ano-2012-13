<%@ Page Language="C#" MasterPageFile="~/LayoutPage_ing.master" AutoEventWireup="true" CodeFile="DescricaoTemp_ing.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

                            <%
                                        String variavel = "0";

                                        variavel = Request.Params.Get("id_temporada");


                                        if (variavel != null)
                                        {
                                            this.setID_TEM(variavel.ToString());
                                        }
                                        else 
                                        {
                                            this.setID_TEM(string.Empty);
                                        }
                            %>

                            <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 250px;"> <%=this.Selecionar_titulo_id()%> </span>
                            <hr style="float: left; margin-left: 50px; height: 5px; width: 650px;" ></hr>

                            <div style=" float:  left; margin-left: 50px; width: 650px; height: auto;" >
                                <img alt="" src="<%= this.Selecionar_imagem_id()%>" style="width: auto; padding-left: 25px; height: auto; border-top: 100px"> </img>

                                <div style=" float:  left;  margin-left: 50px; width: 650px; height: 30px;" ><br></br><br></br></div>

                                <%= this.SelecionarConteudo_id("INGLES")%>
                            </div>

                            <div style=" float:  left;  margin-left: 50px; width: 650px; height: auto;">

                                <div style=" float:  left; width: 325px; height: auto;" >
                                    <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 50px;"> Downloads </span>
                                    <hr style="float: left; margin-left: 25px; height: 5px; width: 250px;" ></hr>
                                    <div style=" float:  left;  margin-left: 50px; width: 650px; height: 30px;" ><br></br></div>
                                    <%= this.SelecionarArquivo_id("INGLES")%>
                                </div>

                                <div style=" float:  right;  width: 325px; height: auto; ">

                                    <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 50px;"> <%= this.Selecionar_titulo_robo("PROTUGUES")%>" </span>
                                    <hr style="float: left; margin-left: 25px; height: 5px; width: 250px;" ></hr>
                                    <img alt="" src="<%= this.Selecionar_imagem_robo()%>" style="width: auto; float: right; padding-right: 50px; height: auto; "> </img>
                                </div>

                                <div style="width: 325px;  height: auto;  font-size: 20px; float: left;color: #000">
                                    <div style=" float:  left;   margin-left: 50px; width: 650px; height: 30px;" ><br></br></div>
                                    <%= this.Selecionar_Conteudo_robo("INGLES")%>
                                </div>
                            </div>

                       
                             

</asp:Content>


        <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
         

        
        
        </asp:Content>

