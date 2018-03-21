<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeModelo.aspx.cs" Inherits="Bhopal2.CadastroDeModelo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Modelo de Toner</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Cadastro de modelo</h3>
    <div class="form-group">
        <label for="txtModeloNome">Modelo</label>
        <asp:TextBox ID="txtModeloNome" class="form-control" placeholder="Digite modelo da impressora" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ddlMarca">Marca</label>
        <asp:DropDownList ID="ddlMarca" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-primary" />
        <button type="reset" class="btn btn-default">Reset</button>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
