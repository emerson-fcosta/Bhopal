<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroToner.aspx.cs" Inherits="Bhopal2.CadastroToner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Toner</title>
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
            <label for="exampleInputEmail1">Cor</label>
            <asp:TextBox ID="TextBox1" type="text" runat="server" class="form-control" placeholder="Digite a cor" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Codigo</label>
            <asp:TextBox ID="TextBox2" type="text" class="form-control" placeholder="Digite o codigo" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:CheckBox ID="CheckBox1"  runat="server" Text=" Colorido ?" />
        </div>
        <asp:Button ID="Button1" runat="server" class="btn btn-default" OnClick="Button1_Click" Text="Salvar" />
    </form>
</body>
</html>
