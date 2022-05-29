<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerTareasEstudiante.aspx.cs" Inherits="Lab3.VerTareasEstudiante" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;font-size:200%">
            <asp:Label ID="Label1" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="ALUMNOS"></asp:Label>
        </div>
        <div style="position: absolute;right:10%">
            <asp:Button ID="Button2" runat="server" Text="Cerrar Sesion" OnClick="Button2_Click" />
        </div>
        <br/>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Seleccionar Asignatura (solo se mostraran las asignaturas en las que está matriculado):"></asp:Label>
            <br/>
            
             <asp:DropDownList AutoPostBack="true" ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <br/>
            <asp:GridView  ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Instanciar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br/>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
