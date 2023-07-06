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

        

        public double getA
        {
            get
            {
                return this.a;
            }
        }

        public double getB
        {
            get
            {
                return this.b;
            }
        }

        public double getC
        {
            get 
            { 
                return this.c;
            }
        }

        public double getDiscriminante()
        {
            return((getB * 2) - 4 * getA * getC);
        }
    }
}
