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
    <div class="form-group">
    <label for="exempleInputEmail1">Impressora</label>
        <asp:DropDownList ID="ddlImpressora" runat="server"></asp:DropDownList>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
