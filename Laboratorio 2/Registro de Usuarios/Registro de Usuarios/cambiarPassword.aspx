<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarPassword.aspx.cs" Inherits="Registro_de_Usuarios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduce tu correo electronico para el cambio de contraseña"></asp:Label>
            <asp:TextBox ID="correo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="correo" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Cambiar contraseña" OnClick="Button1_Click"/>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
