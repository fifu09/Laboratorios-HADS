<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionarTareas.aspx.cs" Inherits="Lab3.WebForm1" %>

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
            <asp:Label ID="Label2" runat="server" Text="GESTION DE TAREAS GENERICAS"></asp:Label>
        </div>
        <div style="position: absolute;right:200px">
        <asp:Button ID="Button2" runat="server" Text="Cerrar Sesion" OnClick="Button2_Click" />
        </div>
        
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Seleccionar asignatura"></asp:Label>
        <br/>
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


        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbdConnectionString %>" 
            SelectCommand="
            SELECT Descripcion, Codigo, HEstimadas, Explotacion, TipoTarea 
            FROM TareaGenerica
            WHERE (CodAsig = @CodAsig)" 
            DeleteCommand="
            DELETE FROM TareaGenerica 
            WHERE Codigo = @Codigo" 
            UpdateCommand="
            UPDATE TareaGenerica 
            SET Descripcion = @Descripcion, HEstimadas = @HEstimadas, Explotacion = @Explotacion, TipoTarea = @TipoTarea 
            WHERE Codigo = @Codigo">

            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="CodAsig" PropertyName="SelectedValue" Type="String" />
            </SelectParameters> 
            <UpdateParameters>
                <asp:Parameter Name="Descripcion" />
                <asp:Parameter Name="HEstimadas" />
                <asp:Parameter Name="Explotacion" />
                <asp:Parameter Name="TipoTarea" />
                <asp:Parameter Name="Codigo" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:Button ID="Button1" runat="server" Text="Insertar Tarea" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="SqlDataSource2" AllowSorting="True">
            <Columns>
                <asp:CommandField SelectText="Modificar" ShowEditButton="True" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                <asp:CheckBoxField DataField="Explotacion" HeaderText="Explotacion" SortExpression="Explotacion" />
                <asp:BoundField DataField="TipoTarea" HeaderText="TipoTarea" SortExpression="TipoTarea" />
            </Columns>
        </asp:GridView>
        <br/>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
