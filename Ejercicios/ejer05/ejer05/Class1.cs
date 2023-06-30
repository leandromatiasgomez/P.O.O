using pra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer05
{
    internal class Serie: IEntregable
    {
        private string titulo = "";
        private int numeroDeTemporadas = 0;
        private bool entregado = false;
        private string genero = "";
        private string creador = "";

        public Serie() { }

        public Serie(string titulo, string creador) 
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int temporadas, bool entregado, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroDeTemporadas = temporadas;
            this.entregado = entregado;
            this.genero = genero;
            this.creador = creador;
        }

        public string getTitulo
        {
            get
            {
                return this.titulo;
            }
        }

        public int getTemporadas
        {
            get
            {
                return this.numeroDeTemporadas;
            }
        }

        public string getGenero
        {
            get
            {
                return this.genero;
            }
        }

        public string getCreador
        {
            get
            {
                return this.creador;
            }
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void setTemporadas(int temporadas)
        {
            this.numeroDeTemporadas = temporadas;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public void setCreador(string creador)
        {
            this.creador = creador;
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
            return this.numeroDeTemporadas;
        }
    }
}
