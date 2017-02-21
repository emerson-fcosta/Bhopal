<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidoDeToner.aspx.cs" Inherits="Bhopal2.scripts.PedidoDeToner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Pedido de Toner</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Pedido de Toner</h3>
    <div class="form-group">
        <label for="exampleInputEmail1">Número do Chamado</label>
        <asp:TextBox ID="txtChamado" class="form-control" placeholder="Informe o número do chamado" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Status</label>
        <asp:TextBox ID="txtStatus" class="form-control" placeholder="(Ex.: Recebido, Enviado para recarga,)" runat="server" OnTextChanged="txtModeloNome_TextChanged"></asp:TextBox>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
