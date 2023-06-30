using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pra
{
    internal class Videojuego : IEntregable
    {
        private string titulo = "";
        private int horasEstimadas = 10;
        private bool entregado = false;
        private string genero = "";
        private string compania = "";

        public Videojuego() { }

        public Videojuego(string titulo, int horas) 
        {
            this.titulo = titulo;
            this.horasEstimadas = horas;
        }

        public Videojuego(string titulo, int horas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horas;
            this.genero = genero;
            this.compania = compania;
        }

        public string getTitulo
        {
            get
            {
                return this.titulo;
            }
        }

        public int getHorasEstimadas
        {
            get
            {
                return this.horasEstimadas;
            }
        }

        public string getGenero
        {
            get
            {
                return this.genero;
            }
        }
        
        public string getCompania
        {
            get
            {
                return this.compania;
            }
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void setHorasEstimadas(int horas)
        {
            this.horasEstimadas = horas;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public void setCompania(string compania)
        {
            this.compania = compania;
        }
        public void entregar()
        {
            this.entregado = true;
        }

        public void devolver()
        {
            this.entregado = false;
        }
        public bool isEntregado()
        {
            return this.entregado;
        }

        public int compareTo()
        {
            return this.horasEstimadas;
        }
    }
}
