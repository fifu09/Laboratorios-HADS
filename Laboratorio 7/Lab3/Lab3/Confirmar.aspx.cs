using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class Confirmar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mbr = Request.QueryString["mbr"];
            int numConf = Convert.ToInt32(Request.QueryString["numconf"]);
            Funciones.Class1.conectar();
            if (Funciones.Class1.verificacion(mbr, numConf))
            {
                Mensaje.Text = "Su cuenta ha sido verificada correctamente";
            }
            else
            {
                Mensaje.Text = "Su cuenta no ha sido verificada correctamente";
            }
            Funciones.Class1.desconectar();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Inicio.aspx");
        }
    }
}