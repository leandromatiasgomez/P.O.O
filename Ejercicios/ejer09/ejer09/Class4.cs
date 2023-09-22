using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    internal class Asiento
    {
        private char fila;
        private char columna;
        private bool ocupado;

        public Asiento(char fila, char columna, bool ocupado)
        {
            this.fila = fila;
            this.columna = columna;
            this.ocupado = ocupado;
        }
    }
}
