<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeFornecedor.aspx.cs" Inherits="Bhopal2.CadastroDeFornecedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Fornecedor</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
   
     <div class="form-group">
     <label for="exampleInputEmail1">Nome Fornecedor</label>
         <asp:textbox id="txtFornecedor" class="form-control" placeholder="Informe o nome do Fornecedor" runat="server" ontextchanged="txtFornecedor_TextChanged"></asp:textbox>
     </div>
    <div  class="form-group">
        <asp:label runat="server" text="Contato"></asp:label>
        <asp:textbox id="txtContato" class="form-control" placeholder="Informe o nome do contato" runat="server" OnTextChanged="txtContato_TextChanged"></asp:textbox>
    </div>
    <div  class="form-group">
        <label for="exampleInputEmail1">Telefone</label>
        <asp:textbox id="txtTelefone" class="form-control" placeholder="Informe o telefone do fornecedor" runat="server"></asp:textbox>
    </div>
    <div class="form-group">
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-primary" />
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
