<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeFornecedor.aspx.cs" Inherits="Bhopal2.CadastroDeFornecedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Fornecedor</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Cadastro de fornecedor</h3>
    <div class="form-group">
        <label for="txtId" hidden></label>
        <asp:TextBox ID="txtId" class="form-control" placeholder="Identificador do registro" runat="server"  type="hidden" />  
    </div>
    <div class="form-group">
        <label for="txtFornecedor">Nome Fornecedor</label>
        <asp:TextBox ID="txtFornecedor" class="form-control" placeholder="Informe o nome do Fornecedor" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Contato"></asp:Label>
        <asp:TextBox ID="txtContato" class="form-control" placeholder="Informe o nome do contato" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtTelefone">Telefone</label>
        <asp:TextBox ID="txtTelefone" class="form-control" placeholder="Informe o telefone do fornecedor" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <a href="fornecedores.aspx" class="btn btn-default" role="button">Voltar</a>
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnSalvar_Click" />
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
