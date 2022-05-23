<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExportarTarea.aspx.cs" Inherits="Lab3.ExportarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;font-size: 200%">
            <asp:Label ID="Label1" runat="server" Text="PROFESOR"></asp:Label>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="EXPORTAR TAREAS GENERICAS"></asp:Label>
        </div>
        <div style="position: absolute;right:10%">
        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesion" OnClick="Button2_Click"/>
        </div>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Seleccione la asignatura para exportar:"></asp:Label>
        <br/>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">

        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Exportar" OnClick="Button1_Click" />
        <br/>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
