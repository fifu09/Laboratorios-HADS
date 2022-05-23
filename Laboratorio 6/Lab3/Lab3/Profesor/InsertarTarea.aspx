<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarTarea.aspx.cs" Inherits="Lab3.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;font-size: 200%">
            <asp:Label ID="Label6" runat="server" Text="PROFESOR"></asp:Label>
            <br/>
            <asp:Label ID="Label7" runat="server" Text="INSERTAR TAREAS GENERICAS"></asp:Label>
        </div>
        <div>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Asignatura"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbdConnectionString %>" 
            SelectCommand="
            SELECT GrupoClase.codigoAsig 
            FROM GrupoClase INNER JOIN ProfesorGrupo 
            ON GrupoClase.codigo = ProfesorGrupo.codigoGrupo 
            WHERE (ProfesorGrupo.email = @email)">
            <SelectParameters>
                <asp:SessionParameter Name="email" SessionField="Email"/>
            </SelectParameters>
        </asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig">
            </asp:DropDownList>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="Horas Estimadas"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
           <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="TextBox4" ErrorMessage="El dato tiene que ser un numero" />
            <br/>
            <asp:Label ID="Label5" runat="server" Text="Tipo Tarea"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Trabajo</asp:ListItem>
                <asp:ListItem>Examen</asp:ListItem>
                <asp:ListItem>Laboratorio</asp:ListItem>
                <asp:ListItem>Ejercicio</asp:ListItem>
            </asp:DropDownList>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Añadir Tarea" OnClick="Button1_Click" />
             <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <br/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesor/GestionarTareas.aspx">Volver</asp:HyperLink>
        </div>

    </form>
</body>
</html>
