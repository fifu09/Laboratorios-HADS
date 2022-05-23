using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class InstanciarTarea : System.Web.UI.Page
    {

        DataSet instancias;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    Funciones.Class1.conectar();
                    string tarea = Request.QueryString["codigo"];
                    string horas = Request.QueryString["horas"];
                    TextBox1.Text = Session["Email"].ToString();
                    TextBox2.Text = tarea;
                    TextBox3.Text = horas;

                    instancias = Funciones.Class1.getInstancias(TextBox1.Text);
                    Session["instancias"] = instancias;
                    GridView1.DataSource = instancias.Tables[0];
                    GridView1.DataBind();
                    Funciones.Class1.desconectar();
                }
                else
                {
                    instancias = (DataSet)Session["instancias"];
                }

            }
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string horas = TextBox4.Text;
            if (horas == "")
            {
                Label6.Text = "HORAS INVALIDAS";
            }
            else
            {
                Funciones.Class1.conectar();
                bool instanciado = Funciones.Class1.InstanciarTarea(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text), (DataSet)Session["instancias"]);
                if (instanciado)
                {
                    DataTable datatable = instancias.Tables[0];
                    DataRow row = datatable.NewRow();
                    row[0] = TextBox1.Text;
                    row[1] = TextBox2.Text;
                    row[2] = TextBox3.Text;
                    row[3] = TextBox4.Text;
                    datatable.Rows.Add(row);
                    GridView1.DataSource = datatable;
                    GridView1.DataBind();
                    Label6.Text = "SE HA INSTANCIADO SIN PROBLEMAS";
                    Funciones.Class1.desconectar();
                }
                else { Label6.Text = "YA HAS INSTANCIADO LA TAREA"; }
                Funciones.Class1.desconectar();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Alumno/VerTareasEstudiante.aspx");
        }
    }
}