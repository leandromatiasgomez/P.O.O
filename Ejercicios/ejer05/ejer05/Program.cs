using pra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer05
{
    class Ejecutable
    {
        static void Main(string[] args)
        {
            Serie[] serie = new Serie[5];
            serie[0] = new Serie("A", 3, false, "terror", "Jose Maria");
            serie[1] = new Serie();
            serie[2] = new Serie("B", "Guillermo");
            serie[3] = new Serie("C", 2, true, "accion", "Fabiana");
            serie[4] = new Serie("D", 1, true, "Terror", "German");

            Videojuego[] videojuegos = new Videojuego[5];
            videojuegos[0] = new Videojuego();
            videojuegos[1] = new Videojuego("A", 15, "Terror", "ABC");
            videojuegos[2] = new Videojuego("B", 9);
            videojuegos[3] = new Videojuego();
            videojuegos[4] = new Videojuego("C", 12);

            serie[0].entregar();
            serie[2].entregar();
            videojuegos[1].entregar();
            videojuegos[2].entregar();
            videojuegos[3].entregar();

            int contadorDeSeries = 0;
            for(int i = 0; i < serie.Count(); i++)
            {
                if (serie[i].isEntregado() == true )
                {
                    contadorDeSeries++;
                }
            }

            int contadorDevideojuegos = 0;
            for (int i = 0; i < videojuegos.Count(); i++)
            {
                if (videojuegos[i].isEntregado() == true)
                {
                    contadorDevideojuegos++;
                }
            }
            
            Console.Write("Cantidad de series entregados: " + contadorDeSeries );
            Console.Write("\nCantidad de video juegos entregados: " + contadorDevideojuegos + "\n");

            int mayorTemporadas = 0;
            int mayorHoras = 0;
            int posicion = 0;

            for (int i = 0; i < serie.Count(); i++)
            {
                if (mayorTemporadas < serie[i].compareTo())
                {
                    mayorTemporadas = serie[i].compareTo();
                    posicion += i;
                }
            }

            Console.WriteLine("\nLa serie con mayor temporadas:\n" + "Titulo: " +serie[posicion].getTitulo + "\nCantidad de temporadas: " + serie[posicion].getTemporadas + "\nEntregado: " + serie[posicion].isEntregado() + "\nCreador: " + serie[posicion].getCreador + "\nGenero: " + serie[posicion].getGenero);

            for (int i = 0; i < videojuegos.Count(); i++)
            {
                if (mayorHoras < videojuegos[i].compareTo())
                {
                    mayorHoras = videojuegos[i].compareTo();
                    posicion += i;
                }
            }

            Console.WriteLine("\nLa serie con mayor temporadas:\n" + "Titulo: " +videojuegos[posicion].getTitulo + "\nHoras estimadas: " + videojuegos[posicion].getHorasEstimadas + "\nEntregado: " + videojuegos[posicion].isEntregado() + "\nCompañia: " + videojuegos[posicion].getCompania + "\nGenero: " + videojuegos[posicion].getGenero);

            Console.ReadKey();
        }
    }
}





