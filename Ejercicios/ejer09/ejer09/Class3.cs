using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    internal class Espectador
    {
        private string nombre;
        private int edad;
        private int dinero;

        public Espectador(string nombre, int edad, int dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
}
