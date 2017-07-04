<%@ Page Language="C#" MasterPageFile="~/LayoutPage.master" AutoEventWireup="true"
    CodeFile="NoticiaAntiga.aspx.cs" Inherits="_NoticiaAntiga" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
    <div style="width: 750px; height: auto; float: left">
        <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60;
            line-height: 25pt; float: left; padding-left: 300px;">
        
        </span>
    </div>
    
    
    <div style="width: 750px; height: auto; float: left">
        <hr style="float: left; margin-left: 50px; height: 5px; width: 650px"></hr>
    </div>
    
    
    <div style="width: 750px; height: 30px; float: left">
        <br></br>
        <br></br>
    </div>
    
    
    <div style="width: 720px; height: auto; padding-left: 30px; float: left; color: #000;
        font-size: 17px;">
        
        <div id="ConteudoChamadaFt" style="width: auto; height: auto; float: left">
            <img src="  " alt="foto " title="foto " name="img1"
                class="imgNoticias" id="img1" />
                
                </div>
                
        <div style="width: 720px; height: auto; padding-left: 30px; float: left; color: #000;
        font-size: 17px;">
            <img src="  " alt="foto " title="foto " name="img1"
                class="imgNoticias" id="img2" />
                </div>
                
                     
          
        <div style="width: 720px; height: auto; padding-left: 30px; float: none; clear:both; color: #000;
        font-size: 17px;">
        
        <form action="NoticiaAntiga.aspx" id="postequipe" name="postequipe" runat="server"
        method="post">
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                     
        </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <script type="text/javascript">
            
            function PegandoValores(variavel)
            {                                  

                document.postequipe.submit();
            }
            
    </script>

</asp:Content>
