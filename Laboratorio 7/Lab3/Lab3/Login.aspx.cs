using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_de_Usuario
{
    public partial class Login : System.Web.UI.Page
    {
        MD5CryptoServiceProvider hash;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            hash = new MD5CryptoServiceProvider();
            hash.Initialize();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string pass = password.Text;
            string hashPassword = Funciones.Class1.getHashPassword(pass);



            Funciones.Class1.conectar();
            Boolean condicion = Funciones.Class1.iniciarSesion(correo.Text, hashPassword);
            System.Diagnostics.Debug.WriteLine(condicion);
            if (condicion)
            {
                Session["Email"] = correo.Text;
                string rol = Funciones.Class1.getRol(correo.Text);
                Session["rol"] = rol;
                if (correo.Text == "vadillo@ehu.es")
                {
                    FormsAuthentication.RedirectFromLoginPage("vadillo", false);
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(rol, false);
                }
                Application.Lock();
                int np = (int)Application.Contents[rol];
                np += 1;
                string arr = "Array" + rol;
                ArrayList array = (ArrayList)Application.Contents[arr];
                array.Add(correo.Text);
                Application.Contents[arr] = array;
                Application.Contents[rol] = np;
                Application.UnLock();
                Funciones.Class1.desconectar();
                Response.Redirect($"{rol}/{rol}.aspx");
            }
            else
            {
                Label3.Text = "Error en el inicio de sesion, usuario no existente o no validado";
            }
            Funciones.Class1.desconectar();
            
        }
    }
}