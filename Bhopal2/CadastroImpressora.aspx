<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroImpressora.aspx.cs" Inherits="Bhopal2.CadastroImpressora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Impressora</title>
    <!-- Bootstrap -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="content/bootstrap.min.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <label for="exampleInputEmail1">Tipo</label>
            <asp:TextBox ID="txtModeloNome" class="form-control" placeholder="Digite tipo de impressora" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Codigo</label>
            <asp:TextBox ID="TextBox1" class="form-control" placeholder="Digite codigo da impressora" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Fornecedor</label>
            <asp:DropDownList ID="ddlFornecedor" class="form-control" runat="server">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Modelo</label>
            <asp:DropDownList ID="ddlModelo" class="form-control" runat="server">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Departamento</label>
            <asp:DropDownList ID="ddlDepartamento" class="form-control" runat="server">
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <button type="button" class="btn btn-primary btn-sm">
            <span class="glyphicon glyphicon-floppy-save" aria-hidden="true"></span>  Salvar
                </button>
            </div>
    </form>
</body>
</html>
