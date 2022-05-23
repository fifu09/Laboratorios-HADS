using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Funciones.Class1.conectar();
            Boolean condicion = Funciones.Class1.iniciarSesion(correo.Text, password.Text);
            if (condicion)
            {
                Session["Email"] = correo.Text;
                Session["Password"] = password.Text;
                Response.Redirect("~/SessionIniciada.aspx");
            }
            else
            {
                Label3.Text = "No ha podido iniciar sesion correctamente";
            }
            Funciones.Class1.desconectar();
            
        }
    }
}