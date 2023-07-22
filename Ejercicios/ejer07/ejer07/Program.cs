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
            Raices raices = new Raices(1,-5,6);

            Console.Write(raices.tieneRaices());
            Console.ReadKey();
        }
    }
}
