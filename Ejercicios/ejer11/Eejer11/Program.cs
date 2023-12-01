using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugadores[] jugadores = new Jugadores[3];
            jugadores[0] = new Jugadores("Daniel", 30, 1, 2, false, 0);
            jugadores[1] = new Jugadores("Pedro", 27, 3, 0, false, 0);
            jugadores[2] = new Jugadores("Walter", 0, 2, 3, false, 0);
            jugadores[3] = new Jugadores("Fabiana", 1, 1, 1, false, 0);

            Pozo pozo = new Pozo();

            int respuesta = 0;

            do
            {
                foreach (Jugadores j in jugadores)
                {
                    if (j.getSaldo >= 1)
                    {
                        j.setPermisoParaJugar(true);
                        j.setRestarSaldo(1);
                        pozo.setSumarSaldo(1);
                    }
                    else
                    {
                        j.setPermisoParaJugar(false);
                    }
                }

                Random rand1 = new Random();
                Random rand2 = new Random();

                int resultadoFinalEquipoA = rand1.Next(0, 10);
                int resultadoFinalEquipoB = rand2.Next(0, 10);

                foreach (Jugadores j in jugadores)
                {
                    if (j.getPermisoParaJugar == true && j.getResultadoEquipoA == resultadoFinalEquipoA && j.getResultadoEquipoB == resultadoFinalEquipoB)
                    {
                        j.setSumarSaldo(2);
                        j.setPermisoParaJugar(false);
                        pozo.setRestarSaldo(2);
                    }
                }

                Console.WriteLine("Resultado: A({0}) vs B({B})\n", resultadoFinalEquipoA, resultadoFinalEquipoB);

                foreach (Jugadores j in jugadores)
                {
                    Console.WriteLine("El jugador {0} gano un total de {1} y su saldo final es de {2}", j.getNombre, j.getCantidadGanadas, j.getSaldo);
                }

                Console.WriteLine("\nSaldo final del pozo: {0}", pozo.getSaldo);

                Console.WriteLine("\n¿Quieres volver a apostar? (si = 0, no = 1): ");
                string linea = Console.ReadLine();
                respuesta = int.Parse(linea);

            } while (respuesta == 0);

        }
    }
}
