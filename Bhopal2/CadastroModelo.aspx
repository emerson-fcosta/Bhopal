<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroModelo.aspx.cs" Inherits="Bhopal2.scripts.CadastroModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Modelo de Toner</title>
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
            <label for="exampleInputEmail1">Modelo</label>
            <asp:TextBox ID="txtModeloNome" class="form-control" placeholder="Digite modelo do toner" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Impressora</label>
            <asp:DropDownList ID="ddlImpressoras" class="form-control" runat="server"></asp:DropDownList>
        </div>
        
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="127px" OnClick="btnSalvar_Click" />
    </form>
</body>
</html>
