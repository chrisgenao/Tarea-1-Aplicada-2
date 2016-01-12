<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rCuentas.aspx.cs" Inherits="Tarea_1.GUI._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href='https://fonts.googleapis.com/css?family=Pacifico' rel='stylesheet' type='text/css'/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <link href="../Common/main.css" rel="stylesheet" />
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/jquery-2.2.0.min.js"></script>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Tarea 1</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li><a href="~/GUI/Main.html">Main</a></li>
                    <li class="active"><a href="rCuentas.aspx">Registro de Cuentas<span class="sr-only">(current)</span></a></li>
                    <li><a href="cCuentas.aspx">Consultas de Cuentas</a></li>
                </ul>
                </div>
            </div>
     </nav>
    <form id="form1" class="" runat="server">
    
        <div>
    
        <asp:Label ID="Label1" runat="server" Text="ID Cuenta: "></asp:Label>
        <br />
        <asp:TextBox ID="IDCuentaTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descripcion: "></asp:Label>
        <br />
        <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Balance: "></asp:Label>
        <br />
        <asp:TextBox ID="BalanceTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="LimpiarButton" runat="server" OnClick="Button2_Click" Text="Limpiar" />
        <asp:Button ID="EnviarButton" runat="server" OnClick="EnviarButton_Click" Text="Enviar" />
        <asp:Button ID="EliminarButton" runat="server" OnClick="Button1_Click" Text="Eliminar" />
    </div>
            </form>
</body>
</html>
