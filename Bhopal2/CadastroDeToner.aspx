<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeToner.aspx.cs" Inherits="Bhopal2.CadastroDeToner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Cadastro de toner</h3>
    <div class="form-group">
        <label for="txtId" hidden></label>
        <asp:TextBox ID="txtId" class="form-control" placeholder="Identificador do registro" runat="server"  type="hidden" />  
    </div>
    <div class="form-group">
        <label for="txtCor">Cor</label>
        <asp:TextBox ID="txtCor" type="text" runat="server" class="form-control" placeholder="Digite a cor"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtCodigo">Codigo</label>
        <asp:TextBox ID="txtCodigo" type="text" class="form-control" placeholder="Digite o codigo" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ddlImpressora">Impressora</label>
        <asp:DropDownList ID="ddlImpressora" class="form-control" AutoPostBack="true" runat="server" ToolTip="Selecione a impressora correspondente ao toner a ser cadastrado">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:CheckBox ID="cbColorida" runat="server" Text=" Colorido ?" />
    </div>
    <div class="form-group">
        <a href="toners.aspx" class="btn btn-default" role="button">Voltar</a>
        <asp:Button ID="btnSalvar" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Salvar" />
    </div>


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
