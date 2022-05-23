using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Funciones.Class1.getRol(Session["Email"].ToString()));
            Funciones.Class1.conectar();
            if (Session["Email"] == null || Session["Password"] == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else if(Funciones.Class1.getRol(Session["Email"].ToString()) == "Profesor")
            {
                Response.Redirect("~/Profesor.aspx");
            }
            else if (Funciones.Class1.getRol(Session["Email"].ToString()) == "Alumno")
            {
                Response.Redirect("~/Alumno.aspx");
            }
            else
            {
                Response.Redirect("~/Error.aspx");
            }
            Funciones.Class1.desconectar();
        }
    }
}