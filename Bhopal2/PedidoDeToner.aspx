<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidoDeToner.aspx.cs" Inherits="Bhopal2.PedidoDeToner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Pedido de Toner</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    
    <h3>Pedido de Toner</h3>

    <div>
        <label for="exempleInputEmail1">Chamado</label>
        <asp:TextBox ID="txtChamado" class="form-control" placeholder="Informe o número do chamado" runat="server"></asp:TextBox>
        </div>
    <div>
        <label for="exempleInputEmail1">Quantidade</label>
        <asp:TextBox ID="txtQuantidade" class="form-control" placeholder="Informe o número de unidades" runat="server"></asp:TextBox>
        </div>
    <div class="form-group">
    <label for="exempleInputEmail1">Filial</label>
        <asp:DropDownList ID="ddlFilial" class="form-control" AutoPostBack="True" ToolTip="Selecione a Filial" runat="server"></asp:DropDownList>
        </div>
    <div class="form-group">
    <label for="exempleInputEmail1">Departamento</label>
        <asp:DropDownList ID="ddlDepartamento" CssClass="form-control" AutoPostBack="true" ToolTip="Selecione o departamento" runat="server"></asp:DropDownList>
        </div>
    <div class="form-group">
    <label for="exempleInputEmail1">Impressora</label>
        <asp:DropDownList ID="ddlImpressora" class="form-control" AutoPostBack="True" ToolTip="Selecione a Impressora" runat="server"></asp:DropDownList>
        </div>
    <div class="form-group">
    <label for="exempleInputEmail1">Marca</label>
        <asp:DropDownList ID="ddlMarca" class="form-control" AutoPostBack="True" ToolTip="Selecione a Marca da Impressora" runat="server"></asp:DropDownList>
        </div>
    <div class="form-group">
    <label for="exempleInputEmail1">Toner</label>
        <asp:DropDownList ID="ddlToner" class="form-control" AutoPostBack="True" ToolTip="Selecione o Toner" runat="server"></asp:DropDownList>
        </div>
    <div>
        <label for="exempleInputEmail1">Data da Solicitação:</label>
        <label for="exempleInputEmail1"><%= DateTime.Now %></label>
        </div>
    <div class="form-group">
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" class="btn btn-primary" OnClick="btnCadastrar_Click"/>
        <button type="reset" class="btn btn-default">Cancelar</button>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
