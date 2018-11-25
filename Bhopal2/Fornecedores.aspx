﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fornecedores.aspx.cs" Inherits="Bhopal2.Fornecedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Fornecedores</title>

    <link href="Content/Datatables/jquery.dataTables.min.css" rel="stylesheet" />

    <script src="scripts/jquery.dataTables.min.js"></script>
    <script src="scripts/dataTables.bootstrap.min.js"></script>

    <script>
        $(document).ready(function () {
            $('#<%=GridViewFornecedores.ClientID %>').DataTable({
                "language": {
                    "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Portuguese-Brasil.json"
                }
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Fornecedores</h3>

    <div class="form-group">
        <a href="cadastrodefornecedor.aspx" class="btn btn-primary" role="button">
            <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>Incluir</a>
    </div>

    <div class="form-group">
        <asp:GridView ID="GridViewFornecedores" runat="server" CssClass="table table-striped" GridLines="None" BorderStyle="None">
            <Columns>
                <asp:CommandField HeaderText="Comandos" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="form-group">
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
