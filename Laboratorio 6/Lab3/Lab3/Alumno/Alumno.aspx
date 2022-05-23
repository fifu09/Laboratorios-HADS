<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="Lab3.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Menu">
            <asp:Button ID="Button1" runat="server" Text="Ver Tareas" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="Cerrar sesion" OnClick="Button3_Click"/>
            <br/>
        </div>
        <div style="text-align: center;font-size:200%">
            <asp:Label ID="Label1" runat="server" Text="Gestion Web de Tareas-Dedicacion"></asp:Label>
            <br/><br/><br/><br/>
            <asp:Label ID="Label2" runat="server" Text="Alumnos"></asp:Label>
        </div>
    </form>
</body>
</html>
