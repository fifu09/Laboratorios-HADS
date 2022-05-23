using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuarios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int codpass = generadorNumeroAleatorio();
            Funciones.Class1.conectar();
            if (Funciones.Class1.insertarCodPass(correo.Text, codpass))
            {
                string body = "Tu codigo de cambio de contraseña es: "+codpass+ " - Introducelo en el siguiente link para confirmar: https://localhost:44303/nuevaPassword.aspx";
                Funciones.Class1.enviarMensaje(correo.Text, "Cambio de contraseña", body);
                Label2.Text = "Se le ha enviado un codigo para realizar el cambio de contraseña";
            }

            Funciones.Class1.desconectar();
        }
        public int generadorNumeroAleatorio()
        {
            Random random = new Random();
            int num = random.Next(100000,999999);
            return num;
        }
    }
}