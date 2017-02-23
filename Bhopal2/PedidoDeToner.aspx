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
        <label for="exampleInputEmail1">Quantidade</label>
        <asp:TextBox ID="txtQauntidade" class="form-control" placeholder="Informe a quantidade" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="exampleInputEmail1">Filial</label>
        <asp:DropDownList ID="ddlFilial" AutoPostBack="true" class="form-control" runat="server" ToolTip="Selecione a filial" OnSelectedIndexChanged="ddlFilial_SelectedIndexChanged">
            </asp:DropDownList>
        </div>

    <div class="form-group">
        <label for="exampleInputEmail1">Departamento</label>
        <asp:DropDownList ID="ddlDepartamento" class="form-control" runat="server" ToolTip="Selecione o departamento" OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged">
            </asp:DropDownList>
        </div>

    <div class="form-group">
        <label for="exampleInputEmail1">Impressora</label>
        <asp:DropDownList ID="ddlImpressora" class="form-control" runat="server" ToolTip="Selecione a impressora">
            </asp:DropDownList>
        </div>


    <div class="form-group">
        <label for="exampleInputEmail1">Data de Solicitação</label>
        <label ID="lblDataSolic" for="exampleInputEmail1"><%= DateTime.Now %></label>
        </div>

    <div class="form-group">
        <asp:Button Text="Cadastrar" runat="server" ID="BtnCad" class="btn btn-primary" />
        <button type="reset" class="btn btn-default">Cancelar</button>
        </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
