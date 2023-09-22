using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    internal class Pelicula
    {
        private string titulo;
        private int duracion;
        private int edadMinima;
        private string director;

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }
        
    }
}
