using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiantes[] estudiantes = new Estudiantes[3];
            estudiantes[0] = new Estudiantes("juan", 15, 'H', 8, 3, true);
            estudiantes[1] = new Estudiantes("maria", 16, 'F', 7, 5, false);
            estudiantes[2] = new Estudiantes("federico", 16, 'H', 5, 4, true);

            Profesores[] profesores = new Profesores[3];
            profesores[0] = new Profesores("Laura", 32, 'F', "matematicas", 1, true);
            profesores[1] = new Profesores("fabiana", 30, 'F', "fisica", 3, true);
            profesores[2] = new Profesores("sergio", 40, 'H', "filosofia", 0, false);

            Console.Write("Ingrese el numero de la clase: ");
            string linea = Console.ReadLine();
            int numeroClase = int.Parse(linea);
            Console.Write("Ingrese la cantidad de alumnos de la clase: ");
            linea = Console.ReadLine();
            int capacidadClase = int.Parse(linea);
            Console.Write("Ingrese la materia de la clase: ");
            string materiaClase = Console.ReadLine();
            Console.Write("Ingrese la cantidad de dias que hay de calses: ");
            linea = Console.ReadLine();
            int cantidadClases = int.Parse( linea);

            Aulas aula = new Aulas(numeroClase, capacidadClase, materiaClase);

            int contadorPresentes = 0;
            int contadorEstudiantes = 0;
            int contadorProfesoresDisponibles = 0;

            foreach (Profesores p in profesores)
            {
                if (p.getMateria == aula.getMateria && p.getPresente == true)
                {
                    contadorProfesoresDisponibles++;
                }
            }
            if (contadorProfesoresDisponibles == 0)
            {
                Console.WriteLine("\nNo se puede dar clases, no hay profesores disponibles.");
            }
            else
            {
                foreach (Estudiantes e in estudiantes) 
                {
                    if (e.getPresente == true)
                    {
                        contadorPresentes++;
                    }

                    contadorEstudiantes++;
                }
                if (contadorPresentes > capacidadClase)
                {
                    Console.WriteLine("\nNo se puede dar clases, no hay espacio suficiente.");
                }
                else if (contadorEstudiantes < (capacidadClase / 2))
                {
                    Console.WriteLine("\nNo se puede dar clases, no hay alumnos suficientes.");
                }
                else
                {
                    Console.WriteLine("\nSe puede dar clases\n");
                    foreach(Estudiantes e in estudiantes)
                    {
                        if (e.getFaltas > (cantidadClases / 2))
                        {
                            Console.WriteLine("El alumno {0} esta desaprobado por acumulacion de faltas" ,e.getNombre);
                        }
                        else
                        {
                            if(e.getNota < 6)
                            {
                                Console.WriteLine("El alumno {0} esta desaprobado", e.getNombre);
                            }
                            else
                            {
                                Console.WriteLine("El alumno {0} esta aprobado", e.getNombre);
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
