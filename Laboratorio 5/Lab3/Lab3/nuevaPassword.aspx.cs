using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Funciones.Class1.conectar();
            if (Funciones.Class1.existeCodPass(correo.Text,Convert.ToInt32(TextBox1.Text)))
            {
                if (Funciones.Class1.insertarPasswordNueva(TextBox2.Text, correo.Text))
                {
                    Label5.Text = "Su contraseña se ha cambiado correctamente";
                }
                else
                {
                    Label5.Text = "Ha habido un error con su cambio de contraseña";
                }
            }
            Funciones.Class1.desconectar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inicio.aspx");
        }
    }
}