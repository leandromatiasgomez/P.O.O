using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    class Cuenta
    {
        private double titular;
        private double cantidad;

        public double ingresar(double cantidad)
        {

            if (cantidad > 0)
            {
                titular += cantidad;
            }

            return titular;
        }

        public double retirar(double cantidad)
        {
            titular -= cantidad;

            if (titular < 0)
            {
                titular = 0;
            }

            return titular;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            double cantidad;
            string linea;
            int estado = 1;

            while (estado == 1)
            {
                Console.Write("Seleccionar una operacion ingresar(1)/retirar(0): ");
                linea = Console.ReadLine();
                estado = int.Parse(linea);

                if (estado == 1)
                {
                    Console.Write("\nIngresar la cantidad a ingresar: ");
                    linea = Console.ReadLine();
                    cantidad = double.Parse(linea);
                    Console.WriteLine("titular: {0}", cuenta.ingresar(cantidad));
                }
                else
                {
                    Console.Write("\nIngresar el monto a retirar: ");
                    linea = Console.ReadLine();
                    cantidad = double.Parse(linea);
                    Console.WriteLine("titular: {0}", cuenta.retirar(cantidad));
                }

                Console.WriteLine("\nSeleccionar una operacion finalizar(0)/volver(1): ");
                linea = Console.ReadLine();
                estado = int.Parse(linea);
                Console.WriteLine("");

            }

        }
    }
}

