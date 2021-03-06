﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeFilial.aspx.cs" Inherits="Bhopal2.scripts.CadastroDeFilial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Filial</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Cadastro de Filial</h3>
    <div class="form-group">
        <label for="txtId" hidden></label>
        <asp:TextBox ID="txtId" class="form-control" placeholder="Identificador do registro" runat="server"  type="hidden" />  
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Nome</label>
        <asp:TextBox ID="txtNome" class="form-control" placeholder="Informe o nome da filial " runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">DDD</label>
        <asp:TextBox ID="txtDDD" class="form-control" placeholder="Informe o DDD da filial" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Codigo</label>
        <asp:TextBox ID="txtCodigo" class="form-control" placeholder="Informe o codigo da filial" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <a href="filiais.aspx" class="btn btn-default" role="button">Voltar</a>
        <asp:Button runat="server" Text="Salvar" class="btn btn-primary" OnClick="Salvar_Click" />
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
