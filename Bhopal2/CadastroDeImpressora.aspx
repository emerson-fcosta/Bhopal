<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeImpressora.aspx.cs" Inherits="Bhopal2.CadastroDeImpressora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Impressora</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Cadastro de impressora</h3>
    <div class="form-group">
        <label for="txtTipo">Tipo</label>
        <asp:TextBox ID="txtTipo" class="form-control" placeholder="Digite tipo de impressora" runat="server" OnTextChanged="txtModeloNome_TextChanged"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtCodigoImpressora">Codigo</label>
        <asp:TextBox ID="txtCodigoImpressora" class="form-control" placeholder="Digite codigo da impressora" runat="server" OnTextChanged="txtCodigoImpressora_TextChanged"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ddlFornecedor">Fornecedor</label>
        <asp:DropDownList ID="ddlFornecedor" class="form-control" runat="server" OnSelectedIndexChanged="ddlFornecedor_SelectedIndexChanged" ToolTip="Selecione o fornecedor">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="ddlMarca">Marca</label>
        <asp:DropDownList ID="ddlMarca" class="form-control" runat="server" OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged" ToolTip="Selecione a marca" AutoPostBack="True">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="ddlModelo">Modelo</label>
        <asp:DropDownList ID="ddlModelo" class="form-control" runat="server">
            <asp:ListItem Text="Selecione uma marca" />
        </asp:DropDownList>
    </div>
    <%--    <div class="form-group">
        <label for="exempleInputEmail">Toner</label>
        <asp:DropDownList ID="ddlToner" class="form-control" runat="server">
        </asp:DropDownList>
    </div>--%>
    <div class="form-group">
        <label for="exampleInputEmail1">Filial</label>
        <asp:DropDownList ID="ddlFilial" class="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFilial_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Departamento</label>
        <asp:DropDownList ID="ddlDepartamento" class="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged">
            <asp:ListItem Text="Selecione uma filial" />
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Button Text="Cadastrar" runat="server" ID="Button1" OnClick="Button1_Click" class="btn btn-primary" />
        <button type="reset" class="btn btn-default">Cancelar</button>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
