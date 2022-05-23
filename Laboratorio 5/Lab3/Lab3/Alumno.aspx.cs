using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null || Session["Password"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else if (Funciones.Class1.getRol(Session["Email"].ToString()) == "profesor")
            {
                Response.Redirect("~/SessionIniciada.aspx");
            }
            else
            {
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VerTareasEstudiante.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");

        }
    }
}