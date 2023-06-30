using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pra
{
    class Persona
    {
        private string nombre;
        private int edad = 0;
        private int dni;
        private char sexo = 'H';
        private double peso = 0;
        private double altura = 0;

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, int dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public int calcularIMC(double peso, double altura)
        {
            double calculo = peso / (altura * altura);
            int imc = 1;

            if (calculo < 20)
            {
                imc = -1;
            }
            else if (calculo >= 20 && calculo <= 25)
            {
                imc = 0;
            }

            return imc;
        }

        public bool esMayorDeEdad(int edad)
        {
            bool mayor = false;

            if (edad >= 18)
            {
                mayor = true;
            }

            return mayor;
        }

        public void comprobarSexo(char sexo)
        {
            string letras = "HM";

            if (letras.Contains(sexo))
            {
                this.sexo = sexo;
            }
            else
            {
                this.sexo = 'H';
            }
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el nobmre de la persona: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresar la edad: ");
            string linea = Console.ReadLine();
            int edad = int.Parse(linea);
            Console.Write("Ingresar el DNI: ");
            linea = Console.ReadLine();
            int dni = int.Parse(linea);
            Console.Write("Ingresar el sexo: ");
            linea = Console.ReadLine();
            char sexo = char.Parse(linea);
            Console.Write("Ingresar el peso: ");
            linea = Console.ReadLine();
            double peso = double.Parse(linea);
            Console.Write("Ingresar la altura: ");
            linea = Console.ReadLine() + "\n";
            double altura = double.Parse(linea);

            Persona persona1 = new Persona(nombre, edad, dni, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona();

            Console.WriteLine("Info: persona1");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("DNI: {0}", dni);
            persona1.comprobarSexo(sexo);
            Console.WriteLine("Sexo: {0} ", sexo);
            Console.WriteLine("Peso {0} ", peso);
            Console.WriteLine("Altura: {0} ", altura);
            Console.WriteLine("IMC: {0}", persona1.calcularIMC(peso, altura));
            Console.WriteLine("Mayoria de edad: {0}\n", persona1.esMayorDeEdad(edad));

            Console.WriteLine("Info: persona2");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Edad: {0}", edad);
            persona2.comprobarSexo(sexo);
            Console.WriteLine("Sexo: {0} ", sexo);
            Console.WriteLine("Mayoria de edad: {0}\n", persona2.esMayorDeEdad(edad));

            persona3.setNombre(nombre = "jose");
            persona3.setEdad(edad = 19);
            persona3.setSexo(sexo = 'H');
            persona3.setPeso(peso = 68);
            persona3.setAltura(altura = 1.74);

            Console.WriteLine("Info: persona3");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Edad: {0}", edad);
            persona1.comprobarSexo(sexo);
            Console.WriteLine("Sexo: {0} ", sexo);
            Console.WriteLine("Peso {0} ", peso);
            Console.WriteLine("Altura: {0} ", altura);
            Console.WriteLine("IMC: {0}", persona3.calcularIMC(peso, altura));
            Console.WriteLine("Mayoria de edad: {0}\n", persona3.esMayorDeEdad(edad));

            Console.ReadKey();
        }
    }
}

