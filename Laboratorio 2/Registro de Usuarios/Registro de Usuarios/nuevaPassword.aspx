<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevaPassword.aspx.cs" Inherits="Registro_de_Usuarios.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Correo electronico: "></asp:Label>
            <asp:TextBox ID="correo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="correo" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator3" ControlToValidate="correo" ValidationExpression="^(.+)@(.+)\.(.+)$" ErrorMessage="Email incorrecto" />
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Codigo de confirmacion: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator1" ControlToValidate="TextBox1" ValidationExpression="^\d{6}$" ErrorMessage="Codigo incorrecto" />
            <br/>
           <asp:Label ID="Label2" runat="server" Text="Contraseña nueva: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator2" ControlToValidate="TextBox2" ValidationExpression="^.{6,}$" ErrorMessage="Minimo 6 caracteres" />
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Repetir contraseña: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Las contraseñas son diferentes"></asp:CompareValidator>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Cambiar contraseña" OnClick="Button1_Click" />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <br/>
            <asp:Button ID="Button2" runat="server" Text="Volver a inicio" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
