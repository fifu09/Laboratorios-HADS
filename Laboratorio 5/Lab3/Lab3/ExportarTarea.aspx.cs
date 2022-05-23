using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class ExportarTarea : System.Web.UI.Page
    {
        DataTable tareas;
        DataView view;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null || Session["Password"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                Funciones.Class1.conectar();
                if (!Page.IsPostBack)
                {
                    
                    DropDownList1.DataTextField = "codigoAsig";
                    DropDownList1.DataValueField = "codigoAsig";
                    DropDownList1.DataSource = Funciones.Class1.getAsignaturasProfesor(Session["Email"].ToString());
                    DropDownList1.DataBind();
                }
                string codAsig = DropDownList1.SelectedValue;
                tareas = Funciones.Class1.getTareaGenerica(codAsig);
                view = new DataView(tareas);
                GridView1.DataSource = view;
                GridView1.DataBind();
                Funciones.Class1.desconectar();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string xml = Server.MapPath("APP_DATA/" + DropDownList1.SelectedValue + ".xml");
            tareas.Columns[0].ColumnMapping = MappingType.Attribute;
            tareas.WriteXml(xml);
            Label3.Text = "guardado en el servidor";
        }
    }
}