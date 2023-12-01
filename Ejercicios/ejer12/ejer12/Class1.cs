using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Revolver
    {
        private int posicionActual;
        private int posicionBala;

        public Revolver() { }

        public bool disparar()
        {
            if (this.posicionActual == this.posicionBala)
            {
                return true;
            }
            else { return false; }
        }

        public int siguienteBala()
        {
            this.posicionActual = this.posicionActual + 1;

            if (this.posicionActual > 6)
            {
                this.posicionActual = 1;
            }

            return this.posicionActual;
        }

        public int getPosicionActual
        {
            get { return this.posicionActual; }
        }

        public int getPosicionBala
        {
            get {return this.posicionBala; }
        }
    }
}
