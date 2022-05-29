<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinador.aspx.cs" Inherits="Lab3.Profesor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: center;font-size:200%">
            <asp:Label ID="Label4" runat="server" Text="COORDINADOR DE TAREAS"></asp:Label>
            <br/>
            <asp:Label ID="Label5" runat="server" Text="PROYECTO GESTION DE TAREAS"></asp:Label>
        </div>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Selecciona una asignatura"></asp:Label>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbdConnectionString %>" 
            SelectCommand=
            "SELECT [codigo] FROM [Asignatura]">
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
        </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Calcular la media" OnClick="Button1_Click" />
            <br/>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label2" runat="server" Text="La media de horas de la asigntura seleccionada es:"></asp:Label>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
        <p>&nbsp;</p>

        </div>
        <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" />
    </form>
</body>
</html>
