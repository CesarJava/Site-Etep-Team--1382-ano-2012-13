<%@ Page Language="C#" MasterPageFile="~/LayoutPage.master" AutoEventWireup="true" CodeFile="Temporadas.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
                           <form action="DescricaoTemp.aspx" id="postemporada" name="postemporada"  method="post">

                                <div style=" width: 500px; height: 250px; float: left; padding-left: 50px; " ><img src="imagens/Equipe.JPG" alt=""  ></img> </div>


                                <div style=" width: 200px; height: 45px; float: left; padding-top: 100px; ">   <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; ">ETEP TEAM</span></div>
                                <hr style="float: left; margin-left: 50px; height: 5px; width: 100px;" ></hr>

                                <div style="  width: 700px; height: 20px; float: left;"><br> </br></div>
                                <div style="  width: 700px; height: 20px; float: left;"><br> </br></div>

                                <div style="  font-size: 20px; color: #000; padding-left: 30px; float: left;">
                                    <div    <span >O ETEP Team #1382 foi criado em 2004 e é um dos únicos times brasileiros.
                                            A cada ano, cerca de 15 alunos entram no time e os antigos permanecem. Aqueles que já se formaram, atuam como mentores, que auxiliam os alunos no desenho e construção do robô e na estratégia.
                                        </span><br />   </div>
                                </div>

                                <div style=" height: 50px; width: 700px; float: left;"><br> </br><br> </br></div>


                                <div style=" height: 50px; width: 500px; float: left; padding-left: 300px; ">   <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; ">Temporada</span></div>
                                <hr style="float: left; margin-left: 50px; height: 5px; width: 700px;" ></hr>

                                <div style=" height: 50px; width: 700px; float: left;"><br> </br><br> </br></div>

                                <div style=" height: auto;width: 400px; font-size: 20px; color: #000; padding-left: 100px">
                                    <%= this.Selecionar()%>

                                </div>
                                <!-- Box Inferior da Ã¡rea de NotÃ­cias-->
                                <input type="hidden" id="id_temporada" name="id_temporada" value="" />
                            </form>
                             

</asp:Content>

  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
         
         <script type="text/javascript">
            function PegandoValores(variavel)
            {
                var index = variavel;

                document.getElementById("id_temporada").value = index;

                document.postemporada.submit();
            }
        </script>
        
        
        </asp:Content>

