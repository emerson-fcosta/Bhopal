<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeMarca.aspx.cs" Inherits="Bhopal2.scripts.CadastroDeMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Marcas</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

<h3>Cadastro de Marca</h3>
    <div class="form-group">
    <label for="exampleInputEmail1">Marca</label>
    <asp:TextBox ID="txtMarca" class="form-control" placeholder="(Ex.: Canon, Ricoh, Brother...)" runat="server"></asp:TextBox>
        </div>
    <div class="form-group">
    <asp:Button ID="btnSalvar" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <button type="reset" class="btn btn-default">Cancelar</button>
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
