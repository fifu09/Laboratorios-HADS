using Biblioteca_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ventana_Comision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            double tVentas = Convert.ToDouble(totalVentas.Text);
            int nVentas = Convert.ToInt32(numeroVentas.Text);
            ComisionTotal.Text = Convert.ToString(v.comision(tVentas, nVentas));
        }
    }
}
