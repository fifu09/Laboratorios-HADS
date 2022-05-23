using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class VerTareasEstudiante : System.Web.UI.Page
    {
        DataTable tareas;
        DataTable asignaturas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null || Session["Password"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else 
            {
                if (!Page.IsPostBack)
                {
                    Funciones.Class1.conectar();
                    asignaturas = Funciones.Class1.getAsignaturas(Session["Email"].ToString());
                    DropDownList1.DataTextField = "codigoAsig";
                    DropDownList1.DataValueField = "codigoAsig";
                    DropDownList1.DataSource = asignaturas;
                    DropDownList1.DataBind();

                    string asignatura = DropDownList1.SelectedValue;
                    tareas = Funciones.Class1.getTareasGenericas();
                    Session["tareas"] = tareas;
                    DataView dv = new DataView(tareas);
                    dv.RowFilter = $"(CodAsig = '{asignatura}' and Explotacion=1)";
                    GridView1.DataSource = dv;
                    GridView1.DataBind();
                    Funciones.Class1.desconectar();
                }
                else
                {
                    tareas = (DataTable)Session["tareas"];
                }
            }
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asignatura = DropDownList1.SelectedValue;
            DataTable temp = (DataTable)Session["tareas"];
            DataView dv = new DataView(temp);
            dv.RowFilter = $"(CodAsig = '{asignatura}' and Explotacion=1)";
            if (dv.Count == 0)
            {
                Label4.Text = "No hay tareas";
            }
            else 
            { 
                Label4.Text = ""; 
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = GridView1.SelectedRow.Cells[1].Text;
            string horas = GridView1.SelectedRow.Cells[4].Text;
            Response.Redirect($"InstanciarTarea.aspx?codigo={codigo}&horas={horas}");
        }
    }
}