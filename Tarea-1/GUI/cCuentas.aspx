<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cCuentas.aspx.cs" Inherits="Tarea_1.GUI.cCuentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Common/main.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
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
                    <li><a href="rCuentas.aspx">Registro de Cuentas</a></li>
                    <li class="active"><a href="cCuentas.aspx">Consultas de Cuentas<span class="sr-only">(current)</span></a></li>
                </ul>
                </div>
        </div>
        </nav>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
    
        <asp:Label ID="Label1" runat="server" Text="Buscar Por: "></asp:Label>
        <asp:DropDownList ID="FiltroDropDown" runat="server">
            <asp:ListItem Selected="True">CuentaId</asp:ListItem>
            <asp:ListItem>Descripcion</asp:ListItem>
            <asp:ListItem>Balance</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text=" = "></asp:Label>
        <asp:TextBox ID="FiltroTextBox" runat="server" Width="313px"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
        <br />
        <asp:GridView ID="BuscarGridView" runat="server" Width="572px">
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/GUI/rCuentas.aspx">Atras</asp:HyperLink>
    </div>
    </form>
</body>
</html>
