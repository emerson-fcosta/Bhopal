<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeMarca.aspx.cs" Inherits="Bhopal2.scripts.CadastroDeMarca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Marcas</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Cadastro de Marca</h3>
    <div class="form-group">
        <label for="txtId" hidden></label>
        <asp:TextBox ID="txtId" class="form-control" placeholder="Identificador do registro" runat="server"  type="hidden" />  
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Marca</label>
        <asp:TextBox ID="txtMarca" class="form-control" placeholder="(Ex.: Canon, Ricoh, Brother...)" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <a href="marcas.aspx" class="btn btn-default" role="button">Voltar</a>
        <asp:Button ID="btnSalvar" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
