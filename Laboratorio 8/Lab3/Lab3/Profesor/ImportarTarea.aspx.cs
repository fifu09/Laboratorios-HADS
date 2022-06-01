using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Lab3
{
    public partial class ImportarTarea : System.Web.UI.Page
    {
        DataTable tareas;
        SqlDataAdapter adapter;
        DataSet dataset;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                adapter = Funciones.Class1.TareasGenericasAdapter();
                dataset = new DataSet();
                adapter.Fill(dataset, "TareaGenerica");
                tareas = dataset.Tables["TareaGenerica"];
                visualizarXML();
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                importarXML();
                Label5.Text = "El importe fue correcto";
            }
            catch
            {
                Label5.Text = "No existe archivo XML";
            }

        }
        protected void visualizarXML()
        {
            System.Diagnostics.Debug.WriteLine(DropDownList1.SelectedValue);
            if (File.Exists(Server.MapPath("../APP_DATA/" + DropDownList1.SelectedValue + ".xml")))
            {
                Label6.Text = "";
                Xml1.DocumentSource = Server.MapPath("../APP_DATA/" + DropDownList1.SelectedValue + ".xml");
                Xml1.TransformSource = Server.MapPath("../APP_DATA/VerTablaTareas.xsl");
                
                
            }
            else
            {
                Label6.Text = "No hay XML para esta asignatura";


            }

        }
        protected void importarXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Server.MapPath("../APP_DATA/" + DropDownList1.SelectedValue + ".xml"));
            XmlNodeList TareasXML;
            TareasXML = xml.GetElementsByTagName("tarea");
            Funciones.Class1.conectar();
            foreach (XmlNode tarea in TareasXML)
            {
                
                bool exists = Funciones.Class1.existeTarea(tarea.Attributes["codigo"].InnerText.ToString());
                if (!exists)
                {
                    DataRow row = tareas.NewRow();
                    row["Codigo"] = tarea.Attributes["codigo"].InnerText.ToString();
                    row["Descripcion"] = tarea.ChildNodes[0].InnerText.ToString();
                    row["CodAsig"] = DropDownList1.SelectedValue;
                    row["HEstimadas"] = Convert.ToInt32(tarea.ChildNodes[1].InnerText.ToString());
                    row["TipoTarea"] = tarea.ChildNodes[2].InnerText.ToString();
                    row["Explotacion"] = Convert.ToBoolean(tarea.ChildNodes[3].InnerText.ToString());
                   
                    tareas.Rows.Add(row);
                }
                
            }
            Funciones.Class1.desconectar();

            SqlCommandBuilder command = new SqlCommandBuilder(adapter);
            adapter.Update(dataset, "TareaGenerica");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/Profesor.aspx");
        }
    }
}