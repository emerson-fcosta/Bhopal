<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeDepartamento.aspx.cs" Inherits="Bhopal2.CadastroDeDepartamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Departamento</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Cadastro de departamentos</h3>
    <div class="form-group">
        <label for="txtId" hidden></label>
        <asp:TextBox ID="txtId" class="form-control" placeholder="Identificador do registro" runat="server"  type="hidden" />  
    </div>
    <div class="form-group">
        <asp:Label ID="lblNomeDept" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNomeDept" class="form-control" placeholder="Informe o departamento" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblSelecFilial" runat="server" Text="Filial"></asp:Label>
        <asp:DropDownList ID="ddlFilial" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <div class="form-group">
        <a href="departamentos.aspx" class="btn btn-default" role="button">Voltar</a>
        <asp:Button ID="Button1" runat="server" Text="Salvar" class="btn btn-primary" OnClick="Button1_Click" />
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
