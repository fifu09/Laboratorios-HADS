using System;
using Biblioteca_de_clases;
namespace Comision_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, introduce el total de ventas");
            double tVentas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora introduce el numero de ventas");
            int nVentas = Convert.ToInt32(Console.ReadLine());
            Ventas v = new Ventas();
            double comision = v.comision(tVentas, nVentas);
            Console.WriteLine("La comision es: "+ comision);
            Console.ReadLine();

        }
    }
}
