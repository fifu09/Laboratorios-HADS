using System;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Funciones.Class1.conectar();
            string rol;
            int numAleatorio = generadorNumeroAleatorio();
            string hashPassword = Funciones.Class1.getHashPassword(TextBox4.Text);
            if (profesor.Checked)
            {
                rol = "Profesor";
            }
            else
            {
                rol = "Alumno";
            }
            Boolean esEmailUsado = Funciones.Class1.registrarUsuario(TextBox1.Text, TextBox2.Text, TextBox3.Text, numAleatorio, rol, hashPassword);
            if (esEmailUsado)
            {
                string protocol = Request.ServerVariables["HTTPS"].ToLower() == "on" ? "https" : "http";
                string server = Request.ServerVariables["SERVER_NAME"];
                string port = Request.ServerVariables["SERVER_PORT"];

                string address = $"{protocol}://{server}:{port}/Confirmar.aspx?mbr={TextBox1.Text}&numconf={numAleatorio}";
                string body = "Suponemos que se quiere registrar " + TextBox1.Text + " y que el número aleatorio que se ha generado es el: " + numAleatorio + ". " +
                                "Entre aqui para confirmar validacion: " + address;


                if (Funciones.Class1.enviarMensaje(TextBox1.Text, "Correo de validacion", body))
                {
                    Label7.Text = "Se ha registrado correctamente, compruebe su correo electronico para validar la cuenta";
                }
                else
                {
                    Label7.Text = "Se ha registrado, pero ha ocurrido un error en el envio del email de confirmacion";
                }
            }
            else
            {
                Label7.Text = "No se ha podido registrarse";
            }
            Funciones.Class1.desconectar();
        }
        public int generadorNumeroAleatorio()
        {
            Random random = new Random();
            int num = (random.Next() * 9000000) + 1000000;
            return num;
        }
    }
}