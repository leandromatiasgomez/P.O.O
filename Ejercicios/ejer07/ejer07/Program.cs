using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices raices = new Raices(1,2,3);

            Console.WriteLine("Dos posibles soluciones: ");
            Console.WriteLine("Unica solucion: ");
            Console.WriteLine("Discriminante: " + raices.getDiscriminante());
            Console.WriteLine("Tiene mas de una solucion: " + raices.tieneRaices());
            Console.WriteLine("Tiene una solución: " + raices.tieneRaiz());
            Console.WriteLine("Posibles soluciones: ");

            Console.ReadKey();
        }
    }
}
