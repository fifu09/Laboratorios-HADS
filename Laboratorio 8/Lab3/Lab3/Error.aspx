<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Lab3.Sesion_iniciada.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Pagina no disponible en este momento, pruebe a iniciar sesion o registrarse"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Volver a inicio" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
