<%@ Page Language="C#" MasterPageFile="~/LayoutPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div id="CaixaChamadaTop">
                                <div id="ConteudoChamadaFt"><img src="imagens/foto_chamada1.jpg" alt="foto " title="foto " name="img1" width="160" height="138" class="imgNoticias" id="img1" />
                                </div>
                                <div id="ConteudoChamada"> 
                                    <span class="cabecalhoN1">NOTÍCIAS</span><br />
                                    <br></br>
                                    <form action="NoticiaCompleta.aspx" id="postnoticia" name="postnoticia"  method="post">

                                     <%= this.exibir_noticia("PORTUGUES")%>
                                        <input type="hidden" id="id_noticia" name="id_noticia" value="" />

                                    </form>
                                </div>
                            </div>
                            <!-- Box Inferior da Ã¡rea de NotÃ­cias-->
                            <div id="CaixaChamadaBottom">
                                <div id="ConteudoChamadaFt2"><img src="imagens/foto_chamada2.jpg" alt="foto " title="foto2 " name="img2" width="160" height="138" class="imgNoticias" id="img2" /></div>
                                <div id="ConteudoChamada2">
                                    <span class="cabecalhoN1">PROGRESSO</span><br />
                                    <br></br>
                                    <form action="ProgressoCompleto.aspx" id="postprogresso" name="postprogresso"  method="post">

                                       <%= this.exibir_progresso("PORTUGUES")%>
                                        <input type="hidden" id="id_progresso" name="id_progresso" value="" />

                                    </form>
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

