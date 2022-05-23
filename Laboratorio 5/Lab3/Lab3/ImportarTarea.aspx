<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImportarTarea.aspx.cs" Inherits="Lab3.ImportarTarea" %>

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
            <asp:Label ID="Label2" runat="server" Text="IMPORTAR TAREAS GENERICAS"></asp:Label>
        </div>
        <div style="position: absolute;right:10%">
        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesion" OnClick="Button2_Click" />
        </div>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Seleccionar asignatura:"></asp:Label>
        <br/>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbdConnectionString %> " 
            SelectCommand="
            SELECT GrupoClase.codigoAsig 
            FROM GrupoClase INNER JOIN ProfesorGrupo 
            ON GrupoClase.codigo = ProfesorGrupo.codigoGrupo 
            WHERE (ProfesorGrupo.email = @email)">
            <SelectParameters>
                <asp:SessionParameter Name="email" SessionField="Email"/>
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataValueField="codigoAsig" DataTextField="codigoAsig">
        </asp:DropDownList>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Importar Tareas" OnClick="Button1_Click" />
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        <br/>
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
