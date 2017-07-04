<%@ Page Language="C#" MasterPageFile="~/LayoutPage_ing.master" AutoEventWireup="true" CodeFile="AcaoSocial_ing.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

                         <%
                                        String variavel = "0";

                                        variavel = Request.Params.Get("id_chairman");

                                        if ( variavel != null) 
                                        {
                                            this.setID_CH(variavel.ToString());
                                        }
                            %>





                            <div style="width: 750px; height: auto ; font-size: 20px; color: #000">


                                <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 300px;">   <%= this.Selecionar_titulo()%></span>
                                <hr style="float: left; margin-left: 50px; height: 5px; width: 650px;" ></hr>
                                <br></br>
                                <br></br>




                                <div style="float: left; margin-left: 50px; height: auto; width: 650px;">

                                    <div style=" float: left;  font-size: 20px; color: #000; ">
                                        <img src="<%= this.Selecionar_imagem()%>" alt="foto " title="foto " style="float: left;   margin-top:5px;" name="img1" width="320" height="200" class="imgNoticias" id="img1" />
                                    </div>

                                    <span >          <%= this.Selecionar( "INGLES")%>
                                    </span><br />


                                </div>
                            </div>

</asp:Content>


        <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
         
          <script type="text/javascript">
            function PegandoValores(variavel)
            {
                var index = variavel;

                document.getElementById("id_chairman").value = index;

                document.postechairman.submit();
            }
        </script>
        
        
        </asp:Content>

