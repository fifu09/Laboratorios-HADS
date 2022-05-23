using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3.Profesor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (Session["Email"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ReferenciaMediaDeHoras.ServicioMediaDeHorasSoapClient service = new ReferenciaMediaDeHoras.ServicioMediaDeHorasSoapClient();
            int horas = service.getHorasMedias(DropDownList1.SelectedValue);
            Label3.Text = horas.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/Profesor.aspx");
        }
    }
}