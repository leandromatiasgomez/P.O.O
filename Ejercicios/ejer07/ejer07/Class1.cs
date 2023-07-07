using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    internal class Raices
    {
        private double a;
        private double b;
        private double c;

        public Raices (double a, double b, double c) 
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public string obtenerRaices()
        {
            double res1 = (-b + ((b * 2) - (4 * a * c))) / (2 * a);
            double res2 = (-b - ((b * 2) - (4 * a * c))) / (2 * a);

            return ("primero resultado: " + res1 + "\nsegundo resultado: " + res2);
        }

        public string obtenrRaiz()
        {
            double res1 = (-b + ((b * 2) - (4 * a * c))) / (2 * a);
            double res2 = (-b - ((b * 2) - (4 * a * c))) / (2 * a);

            if (res1 == res2)
            {
                return ("Resultado: " + res1);
            }
            else
            {
                return ("Hay más de una solucion");
            }
        }

        public double getDiscriminante()
        {
            return ((b * 2) - 4 * a * c);
        }

        public bool tieneRaices()
        {
            if(getDiscriminante() >= 0) { return true; } else { return false; } 
        }

        public bool tieneRaiz()
        {
            if(getDiscriminante() == 0) { return true; } else { return false;}
        }

    }
}
