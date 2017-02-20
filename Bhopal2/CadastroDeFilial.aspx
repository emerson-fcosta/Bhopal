﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeFilial.aspx.cs" Inherits="Bhopal2.scripts.CadastroDeFilial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Filial</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Cadastro de Filial</h3>

    <div class="form-group">
    <label for="exampleInputEmail1" >Nome</label>
        <asp:textbox id="txtNome" class="form-control" placeholder="Informe o nome da filial " runat="server"></asp:textbox>
    </div>
    <div class="form-group">
    <label for="exampleInputEmail1">DDD</label>
        <asp:textbox ID="txtDDD" class="form-control" placeholder="Informe o DDD da filial" runat="server"></asp:textbox>
        </div>
    <div class="form-group">
    <label for="exampleInputEmail1">Codigo</label>
        <asp:textbox ID="txtCodigo" class="form-control" placeholder="Informe o codigo da filial" runat="server"></asp:textbox>
        </div>
    <div class="form-group">
    <asp:button runat="server" text="Salvar" class="btn btn-primary" OnClick="Unnamed1_Click"/>
    <button runat="server" type="reset" class="btn btn-default">Cancelar</button>
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
