﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="Lab3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Menu">
            <asp:Button ID="Button1" runat="server" Text="Tareas" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Importar XML" OnClick="Button2_Click" />
            <asp:Button ID="Button4" runat="server" Text="Exportar" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Coordinador" OnClick="Button5_Click"/>
            <asp:Button ID="Button3" runat="server" Text="Cerrar session" OnClick="Button3_Click"/>
            <br/>
        </div>
        <div style="text-align: center;font-size:200%">
            <asp:Label ID="Label1" runat="server" Text="Gestion Web de Tareas-Dedicacion"></asp:Label>
            <br/><br/><br/><br/>
            <asp:Label ID="Label2" runat="server" Text="Profesores"></asp:Label>
        </div>


        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="1000">
        </asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server" Text="Personas conectadas:"></asp:Label>
                <br/>
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" />
            </Triggers>
        </asp:UpdatePanel>



    </form>
</body>
</html>
