using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                int numAlumnos = (int)Application.Get("Alumno");
                int numProfesores = (int)Application.Get("Profesor");
                Label3.Text = "Numero de personas conectadas- Alumnos: " + Convert.ToString(numAlumnos) + " Profes: " + Convert.ToString(numProfesores);
                
                ArrayList arrayAlumnos = (ArrayList)Application.Contents["ArrayAlumno"];
                ListBox1.Items.Clear();
                foreach (string a in arrayAlumnos)
                {
                    ListBox1.Items.Add(a);
                }
                ListBox1.DataBind();

                ArrayList arrayProfesor = (ArrayList)Application.Contents["ArrayProfesor"];
                ListBox2.Items.Clear();
                foreach (string a in arrayProfesor)
                {
                    ListBox2.Items.Add(a);
                }
                ListBox2.DataBind();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Inicio.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/InsertarTarea.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/GestionarTareas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/ImportarTarea.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/ExportarTarea.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/Coordinador.aspx");
        }
    }
}