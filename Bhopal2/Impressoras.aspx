<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Impressoras.aspx.cs" Inherits="Bhopal2.Impressoras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <!-- Datatables -->
    <link href="/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css" rel="stylesheet">
    <link href="/bower_components/datatables.net-buttons-bs/css/buttons.bootstrap.min.css" rel="stylesheet">
    <link href="/bower_components/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css" rel="stylesheet">
    <link href="/bower_components/datatables.net-responsive-bs/css/responsive.bootstrap.min.css" rel="stylesheet">
    <link href="/bower_components/datatables.net-scroller-bs/css/scroller.bootstrap.min.css" rel="stylesheet">

    <title>Impressoras | Bhopal</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h3>Listar Impressoras</h3>
    <div class="row">
        <div class="col-md-6"></div>
        <div class="col-md-6 text-right">
            <a href="CadastroDeImpressora.aspx">
                <button type="button" class="btn btn-success">
                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>
                </button>
            </a>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="GridViewImpressora" runat="server" CssClass="table table-striped" GridLines="None" BorderStyle="None"></asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
    <script src="/bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
    <script src="/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
    <script src="/bower_components/datatables.net-buttons/js/dataTables.buttons.min.js"></script>
    <script src="/bower_components/datatables.net-buttons-bs/js/buttons.bootstrap.min.js"></script>
    <script src="/bower_components/datatables.net-buttons/js/buttons.flash.min.js"></script>
    <script src="/bower_components/datatables.net-buttons/js/buttons.html5.min.js"></script>
    <script src="/bower_components/datatables.net-buttons/js/buttons.print.min.js"></script>
    <script src="/bower_components/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js"></script>
    <script src="/bower_components/datatables.net-keytable/js/dataTables.keyTable.min.js"></script>
    <script src="/bower_components/datatables.net-responsive/js/dataTables.responsive.min.js"></script>
    <script src="/bower_components/datatables.net-responsive-bs/js/responsive.bootstrap.js"></script>
    <script src="/bower_components/datatables.net-scroller/js/datatables.scroller.min.js"></script>
    <script src="/bower_components/jszip/dist/jszip.min.js"></script>
    <script src="/bower_components/pdfmake/build/pdfmake.min.js"></script>
    <script src="/bower_components/pdfmake/build/vfs_fonts.js"></script>

    <script>
        var table = $('#<%= GridViewImpressora.ClientID %>').DataTable({
            dom: "Bfrtip",
            language: {
                search: "Pesquisar:",
                lengthMenu: "Exibir _MENU_ itens",
                info: "Mostrando _START_ a _END_ de _TOTAL_ registros",
                infoEmpty: "Affichage de l'&eacute;lement 0 &agrave; 0 sur 0 &eacute;l&eacute;ments",
                infoFiltered: "(filtrados de _MAX_ itens no total)",
                infoPostFix: "",
                decimal: ",",
                paginate: {
                    first: "Primeiro",
                    previous: "Anterior",
                    next: "Próximo",
                    last: "Ultimo"
                },

            },
            buttons: [
                'copy', 'excel', 'pdf'
            ],
            responsive: true
        });
    </script>
</asp:Content>
