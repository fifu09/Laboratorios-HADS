using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Ventas
    {
        public double comision(double TotalVentas, int NumeroDeVentas)
        {
            double comision = TotalVentas*0.025+
                ((TotalVentas/NumeroDeVentas)*0.05);
            return comision;
        }
    }
}
