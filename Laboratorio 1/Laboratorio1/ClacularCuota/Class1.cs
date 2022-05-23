using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClacularCuota
{
    public class BibliotecaCuota
    {
        public string calcularCuotaAnual(double capital, int plazo, double interes)
        {
            string cuotaAnual = Convert.ToString((capital * interes) / (1 - (Math.Pow((1 + interes), -plazo))));
            return cuotaAnual;
        }
    }
}
