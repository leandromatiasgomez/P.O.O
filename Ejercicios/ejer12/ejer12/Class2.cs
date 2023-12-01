using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo = true;

        public Jugador() { }

        public bool disparar(Revolver r)
        {
            if (r.getPosicionActual == r.getPosicionBala)
            {
                this.vivo = false;
                return vivo;
            }
            else
            {
                this.vivo = true;
                return vivo;
            }
        }

        public int getId 
        {
            get { return this.id; }
        }

        public string gerNombre
        {
            get { return this.nombre; }
        }

        public bool getVivo
        {
            get { return this.vivo}
        }
    }
}
