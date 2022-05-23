<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cliente_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Capital"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Plazo"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Interes"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="Cuota Anual"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Calcular Cuota" OnClick="Button1_Click" />
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
        </div>
    </form>
</body>
</html>
