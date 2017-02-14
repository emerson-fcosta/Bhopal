﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeDepartamento.aspx.cs" Inherits="Bhopal2.CadastroDeDepartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Cadastro de Departamento</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">


<div class="form-group">
        <asp:Label ID="lblNomeDept" runat="server" Text="Nome"></asp:Label>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtNomeDept" class="form-group" placeholder="Informe o departamento" runat="server" ></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="lblSelcFilial" runat="server" Text="Filial"></asp:Label>
    </div>
    <div class="form-group">
        <asp:DropDownList ID="ddlFilial" CssClass="form-control" runat="server"></asp:DropDownList>
    </div>
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
