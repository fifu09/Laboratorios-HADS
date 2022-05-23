<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Registro_de_Usuario.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Correo electronico"></asp:Label>
            <asp:TextBox ID="correo" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="correo" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Iniciar sesion" OnClick="Button1_Click1"/>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>


        </div>
    </form>
</body>
</html>
