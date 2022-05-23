using System;
using System.Collections;
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
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                int numAlumnos = (int)Application.Get("Alumno");
                int numProfesores = (int)Application.Get("Profesor");
                Label3.Text = "Numero de personas conectadas: profesores: " + Convert.ToString(numProfesores) + ", Alumnos: " + Convert.ToString(numAlumnos);
                ArrayList arrayProfesor = (ArrayList)Application.Contents["ArrayProfesor"];
                ListBox1.Items.Clear();
                foreach (string a in arrayProfesor)
                {
                    ListBox1.Items.Add(a);
                }
                ListBox1.DataBind();
                ArrayList arrayAlumnos = (ArrayList)Application.Contents["ArrayAlumno"];
                ListBox2.Items.Clear();
                foreach (string a in arrayAlumnos)
                {
                    ListBox2.Items.Add(a);
                }
                ListBox2.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Alumno/VerTareasEstudiante.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");

        }
    }
}