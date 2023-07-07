using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    internal class Libro
    {
        private int ISBN;
        private string autor;
        private string titulo;
        private int numeroPaginas;

        public Libro(int ISBN, string autor, string titulo, int paginas) 
        {
            this.ISBN = ISBN;
            this.autor = autor;
            this.titulo = titulo;
            this.numeroPaginas = paginas;
        }

        public int getISBN
        {
            get
            {
                return this.ISBN;
            }
        }

        public int getNumeroPaginas
        {
            get
            {
                return this.numeroPaginas;
            }
        }

        public string getAutor
        {
            get
            {
                return this.autor;
            }
        }

        public string getTitulo
        {
            get
            {
                return this.titulo;
            }
        }

        public void setIBSN(int IBSN)
        {
            this.ISBN = IBSN;
        }

        public void setNumeroPaginas(int paginas)
        {
            this.numeroPaginas = paginas;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string infoLibro()
        {
            string info = "El libro " + getISBN + " creado por " + getAutor + ", tiene " + getNumeroPaginas + " paginas.";

            return info;
        }
    }
}
