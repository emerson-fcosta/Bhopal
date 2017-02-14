<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroDepartamento.aspx.cs" Inherits="Bhopal2.scripts.CadastroDepartamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Departamento</title>
    
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
        <asp:Label ID="lblNomeDept" runat="server" Text="Nome"></asp:Label>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtNomeDept" class="form-group" placeholder="Selecione a filial" runat="server" ></asp:TextBox>
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
    </form>
</body>
</html>
