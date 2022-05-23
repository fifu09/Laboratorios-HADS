using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class InsertarTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Funciones.Class1.existeTarea(TextBox1.Text) == true)
            {
                Label8.Text = "Ya existe una tarea con ese codigo";
            }
            else
            {
                if (Funciones.Class1.insertarTarea(TextBox1.Text, TextBox2.Text, DropDownList1.SelectedValue, Convert.ToInt32(TextBox4.Text), DropDownList2.SelectedValue))
                {
                    Label8.Text = "Tarea incluida";
                }
                else
                {
                    Label8.Text = "Error al incluir la tarea";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GestionarTareas.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}