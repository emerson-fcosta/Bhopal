<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeModelo.aspx.cs" Inherits="Bhopal2.CadastroDeModelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Modelo de Toner</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

     <div class="form-group">
            <label for="exampleInputEmail1">Modelo</label>
            <asp:TextBox ID="txtModeloNome" class="form-control" placeholder="Digite modelo do toner" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnSalvar"  runat="server" Text="Salvar" Width="127px" OnClick="btnSalvar_Click" class="btn btn-primary"/>
        </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
