using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finJuego(Jugador j)
            {
                if (j.getVivo == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            void ronda(Jugador j)
            {
                if (j.getVivo == true)
                {
                    Console.Write("\nel jugador {0} sigue vivo", j.getNombre);
                }
                else
                {
                    Console.Write("\nel jugador {0} a fallecido", j.getNombre);
                }
            }

            Jugador[] jugador = new Jugador[5];
            jugador[0] = new Jugador(1,"Jose", true);
            jugador[1] = new Jugador(2, "Maria", true);
            jugador[2] = new Jugador(3, "Jorge", true);

            Random r1 = new Random();
            Random r2 = new Random();

            int posicion = r1.Next(1,6);
            int posicionBala = r2.Next(1,6);

            Revolver revolver = new Revolver(1, 3);

            for (int i = 0; i < jugador.Count(); i++)
            {
                jugador[i].disparar(revolver);
                ronda(jugador[i]);

                if (finJuego(jugador[i]) == true)
                {
                    Console.Write("\nEl juego termino");
                    i = jugador.Count();
                }

            }

            Console.ReadKey();
        }
    }
}
