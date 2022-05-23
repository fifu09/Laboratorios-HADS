<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Registro_de_Usuario.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesion" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Registrarse" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cambiar contraseña" />
        </div>
    </form>
</body>
</html>
