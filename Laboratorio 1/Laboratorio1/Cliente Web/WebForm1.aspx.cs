using ClacularCuota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BibliotecaCuota b = new BibliotecaCuota();
            TextBox4.Text = Convert.ToString(
                               b.calcularCuotaAnual(Convert.ToDouble(TextBox1.Text),
                                                    Convert.ToInt32(TextBox2.Text),
                                                    Convert.ToDouble(TextBox3.Text) / 100));
        }
    }
}