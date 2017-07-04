<%@ Page Language="C#" MasterPageFile="~/LayoutPage_ing.master" AutoEventWireup="true" CodeFile="Equipe_ing.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
                            <%
                                String variavel = "0";

                                variavel = Request.Params.Get("nome_imagem");

                                if (variavel != null)
                                {
                                           this.setID_EQ(variavel.ToString());
                                        }
                            %>


                            <div id="CaixaChamadaBottom">


                                <div  id="ConteudoChamada2">
                                    <div style="width: 750px; font-size: 20px; color: #000">

                                        <!--    <h2 style=" color: orangered; float: left; padding-left: 300px">    </h2>
                                        -->
                                        <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 300px;"><%= this.Selecionar_titulo()%></span><br />
                                        <hr style="float: left; margin-left: 50px; height: 5px; width: 650px;" ></hr>
                                        <img src="<%= this.Selecionar_imagem()%>" alt="foto " title="foto " style="float: right; margin-right: 50px;  margin-top:5px;" name="img1" width="120" height="180" class="imgNoticias" id="img1" />
                                        <br></br>
                                        <br></br>
                                        <div style="width: 520px; padding-left: 60px; font-size: 20px; color: #000"> <%= this.Selecionar("INGLES")%></div>
                                    </div>
                                </div>
                            </div>
                             

</asp:Content>

  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
          <script type="text/javascript">
            function PegandoValores(variavel)
            {
                var index = variavel;

                document.getElementById("id_noticia").value = index;

                document.postnoticia.submit();
            }
        </script>

        <script type="text/javascript">
            function PegandoValores_prog(variavel)
            {
                var index = variavel;

                document.getElementById("id_progresso").value = index;

                document.postprogresso.submit();
            }
        </script>
        
        
        </asp:Content>

