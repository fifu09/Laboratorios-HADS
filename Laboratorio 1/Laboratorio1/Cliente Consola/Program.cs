using ClacularCuota;
using System;

namespace Cliente_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceme el capital");
            double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceme el plazo");
            int plazo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceme el interes (ejemplo: 1,5)");
            double interes = Convert.ToDouble(Console.ReadLine())/100;
            BibliotecaCuota c = new BibliotecaCuota();
            Console.WriteLine("Tu cuota anual es :" + c.calcularCuotaAnual(capital,plazo,interes));
            Console.ReadLine();
        }
    }
}
