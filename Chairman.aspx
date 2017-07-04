<%@ Page Language="C#" MasterPageFile="~/LayoutPage.master" AutoEventWireup="true" CodeFile="Chairman.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div>   <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 300px;">CHAIRMAN'S</span></div>
                            <hr style="float: left; margin-left: 50px; height: 5px; width: 650px;" ></hr>
                            <div style="float: left; height: 50px; width: 750px;"><br> </br></div>
                            <div style=" float: left; width: 700px; height: auto;padding-left: 100px; " ><img src="Chairman/chairman.JPG" alt=""  ></img> </div>
                            <div style=" float: left; width: 700px; height: 30px;padding-left: 100px; "><br> </br></div>
                            <div style="float: left;  font-size: 20px; color: #000; padding-left: 30px">
                                <div    <span >o Chairman's é o principal prêmio do FIRST, o qual visa a realização de ações sociais que disseminam a ciência e tecnologia.
                                        Para ações sociais realizamos:
                                    </span><br />
                                </div>

                            </div>
                            <div style=" float: left; width: 700px; height: 30px;padding-left: 100px; "><br> </br></div>
                            <form action="AcaoSocial.aspx" id="postechairman" name="postechairman"  method="post">

                                <div style="height: auto; width: 400px; font-size: 20px; color: #000; padding-left: 100px">
                                    <%= this.Selecionar("PORTUGUES")%>

                                </div>
                                <!-- Box Inferior da Ã¡rea de NotÃ­cias-->
                                <input type="hidden" id="id_chairman" name="id_chairman" value="" />
                            </form>
                             

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

