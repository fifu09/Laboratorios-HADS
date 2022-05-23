<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ComisionEnWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 201px">
            <asp:Label ID="TotalVentas" runat="server" Text="Total Ventas"></asp:Label>
            <br/>
            <asp:TextBox ID="inputTotalVentas" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="NumeroVentas" runat="server" Text="Numero Ventas"></asp:Label>
            <br/>
            <asp:TextBox ID="inputNumeroVentas" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Calcular Comision" />
            <br/>
            <asp:Label ID="Resultado" runat="server" Text="La comision es:"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </div>
    </form>
</body>
</html>
