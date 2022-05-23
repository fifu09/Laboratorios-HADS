<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmar.aspx.cs" Inherits="Registro_de_Usuarios.Confirmar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Mensaje" runat="server" Text=""></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Volver al inicio" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
