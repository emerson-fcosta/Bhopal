<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImportarArquivo.aspx.cs" Inherits="Bhopal2.ImportarArquivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <h3>Importar arquivo de impressões</h3>

    <div class="form-group">
        <label class="form-check-label" >Selecione um arquivo</label>
        <asp:fileupload runat="server" CssClass="form-control"></asp:fileupload>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
