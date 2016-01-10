<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Tarea_1.GUI._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <script src="../scripts/jquery-2.2.0.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>

    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="ID Cuenta: "></asp:Label>
        <asp:TextBox ID="CuentaTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" OnClick="Button1_Click" Text="Buscar" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Balance: "></asp:Label>
        <asp:TextBox ID="BalanceTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="EnviarButton" runat="server" OnClick="BuscarButton_Click" Text="Enviar" />
    
    </div>
    </form>
</body>
</html>
