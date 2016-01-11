<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cCuentas.aspx.cs" Inherits="Tarea_1.GUI.cCuentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
        <asp:GridView ID="GridView1" runat="server" Width="546px"></asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/GUI/rCuentas.aspx">Atras</asp:HyperLink>
    </div>
    </form>
</body>
</html>
