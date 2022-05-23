<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Registro_de_Usuario.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Label ID="Label1" runat="server" Text="Correo electronico: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator1" ControlToValidate="TextBox1" ValidationExpression="^(.+)@(.+)\.(.+)$" ErrorMessage="Email incorrecto" />
            <br/>
            <asp:Button ID="Button2" runat="server" Text="Comprobar matriculacion" OnClick="Button2_Click" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TextBox1" EventName="TextChanged" />
            </Triggers>
        </asp:UpdatePanel>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" type="password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" id="RegularExpressionValidator2" ControlToValidate="TextBox4" ValidationExpression="^.{6,}$" ErrorMessage="Minimo 6 caracteres" />
            <br/>
            <asp:Label ID="Label5" runat="server" Text="Repetir contraseña: "></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" type="password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Dato no rellenado"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Las contraseñas son diferentes"></asp:CompareValidator>
            <br/>
            <asp:Label ID="Label6" runat="server" Text="Rol: "></asp:Label>
            <asp:RadioButton ID="profesor" runat="server" GroupName="rol" Text="Profesor" checked="true"/>
            <asp:RadioButton ID="alumno" runat="server" GroupName="rol" Text="Alumno"/>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Registrarse" OnClick="Button1_Click" />
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <p>&nbsp;</p>
        </div>
    </form>
</body>
</html>
