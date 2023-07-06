using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(001, "Jose", "A", 120);
            Libro libro2 = new Libro(002, "Maria", "B", 200);

            Console.WriteLine(libro1.infoLibro());
            Console.WriteLine(libro2.infoLibro());

            if (libro1.getNumeroPaginas < libro2.getNumeroPaginas)
            {
                Console.WriteLine("El libro con más paginas es: " + libro2.infoLibro());
            }
            else if (libro1.getNumeroPaginas > libro2.getNumeroPaginas)
            {
                Console.WriteLine("El libro con más paginas es: " + libro1.infoLibro());
            }
            else
            {
                Console.WriteLine("Ambos libros tiene la misma cantidad de paginas");
            }

            Console.ReadKey();
        }
    }
}
