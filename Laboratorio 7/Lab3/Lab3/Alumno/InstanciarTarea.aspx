<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstanciarTarea.aspx.cs" Inherits="Lab3.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;font-size:200%">
            <asp:Label ID="Label6" runat="server" Text="INSTANCIAR TAREA GENERICA"></asp:Label>
            <br/>
            <asp:Label ID="Label7" runat="server" Text="ALUMNOS"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Tarea"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="Horas estimadas"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
            <br/>
            <asp:Label ID="Label5" runat="server" Text="Horas reales"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Instanciar tarea" OnClick="Button1_Click"/>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br/>
            <asp:Button ID="Button2" runat="server" Text="Volver a ver tareas" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
