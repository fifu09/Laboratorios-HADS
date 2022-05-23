using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca_de_clases;

namespace ComisionEnWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            TextBox1.Text = Convert.ToString(v.comision(Convert.ToDouble(inputTotalVentas.Text), Convert.ToInt32(inputNumeroVentas.Text)));
        }
    }
}