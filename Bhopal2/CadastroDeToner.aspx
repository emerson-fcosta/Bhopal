<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeToner.aspx.cs" Inherits="Bhopal2.CadastroDeToner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Cadastro de toner</h3>
    <div class="form-group">
        <label for="exampleInputEmail1">Cor</label>
        <asp:TextBox ID="TextBox1" type="text" runat="server" class="form-control" placeholder="Digite a cor" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Codigo</label>
        <asp:TextBox ID="TextBox2" type="text" class="form-control" placeholder="Digite o codigo" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:CheckBox ID="CheckBox1" runat="server" Text=" Colorido ?" />
    </div>
    <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Salvar" />
    <button type="reset" class="btn btn-default">Reset</button>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
