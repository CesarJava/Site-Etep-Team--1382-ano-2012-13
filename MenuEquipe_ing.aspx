﻿<%@ Page Language="C#" MasterPageFile="~/LayoutPage_ing.master" AutoEventWireup="true" CodeFile="MenuEquipe_ing.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <span class="cabecalhoN1" style="font-size: 30px; font-weight: 700; color: #F60; line-height: 25pt; float: left; padding-left: 250px;">Team Members</span><br />
                            <hr style="float: left; margin-left: 50px; height: 5px; width: 650px;" ></hr>
                            <!-- <div  style=" width: 750px;  float: left;  padding-left: 300px; "> <h1 style="color: orangered"></h1></div>-->

                            <div  style=" width: 750px;  float: left;  padding-left: 30px;  color: #666;">  <h1 class="perfil">Students</h1></div>
                            <form action="Equipe_ing.aspx" id="postequipe" name="postequipe"  method="post">

                                <%= this.SelecionarAluno("INGLES")%>



                                <div  style=" width: 750px;  float: left;  padding-left: 30px; color: #666;">  <h1 class="perfil">Mentors</h1></div>


                                <%= this.SelecionarMentor("INGLES")%>

                                <input type="hidden" id="nome_imagem" name="nome_imagem" value="" />
                            </form>
     
                             

</asp:Content>


        <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
         
         <script type="text/javascript">
            function PegandoValores(variavel)
            {
                var index = variavel;

                document.getElementById("nome_imagem").value = index;

                document.postequipe.submit();
            }
        </script>
        
        
        </asp:Content>

