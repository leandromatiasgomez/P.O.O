using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espectador[] espectador = new Espectador[8];
            espectador[0] = new Espectador("Juan", 18, 350);

            Cine cine = new Cine(500);
        }
    }
}
