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

        public Jugador(int id, string nombre, bool vivo)
        {
            this.id = id;
            this.nombre = nombre;
            this.vivo = vivo;
        }

        public bool disparar(Revolver r)
        {
            if (r.disparar() == true)
            {
                this.vivo = false;
                return this.vivo;
            }
            else
            {
                this.vivo = true;
                return this.vivo;
            }
        }

        public int getId 
        {
            get { return this.id; }
        }

        public string getNombre
        {
            get { return this.nombre; }
        }

        public bool getVivo
        {
            get { return this.vivo; }
        }

        public void setVivo(bool vivo) 
        {
            this.vivo = vivo;
        }
    }
}
