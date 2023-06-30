using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer04
{
    class Electrodomestico
    {
        private int precio_base = 100;
        private string color = "BLANCO";
        private char consumo_energetico = 'F';
        private double peso = 5;

        public Electrodomestico() { }

        public Electrodomestico(int precio, double peso)
        {
            this.precio_base = precio;
            this.peso = peso;
        }

        public Electrodomestico(int precio, string color, char consumo, double peso)
        {
            this.precio_base = precio;
            comprobarColor(color);
            comprobarConsumoEnergetico(consumo);
            this.peso = peso;
        }

        public int getPrecioBase
        {
            get
            {
                return this.precio_base;
            }
        }

        public string getColor
        {
            get
            {
                return this.color;
            }
        }

        public char getConsumoEnergetico
        {
            get
            {
                return this.consumo_energetico;
            }
        }

        public double getPeso
        {
            get
            {
                return this.peso;
            }
        }

        private void comprobarConsumoEnergetico(char letra)
        {
            string letrasPosibles = "ABCDEF";

            if (letrasPosibles.Contains(letra))
            {
                this.consumo_energetico = letra;
            }
            else
            {
                this.consumo_energetico = 'F';
            }
        }

        private void comprobarColor(string color)
        {
            string coloresPosibles = "BLANCONEGROROJOAZULGRIS";

            if (coloresPosibles.Contains(color.ToUpper()))
            {
                this.color = color;
            }
            else
            {
                this.color = "BLANCO";
            }
        }

        public int precioFinal()
        {
            int precio = this.precio_base;

            switch (this.consumo_energetico)
            {
                case 'A':
                    this.precio_base += 100;
                    break;

                case 'B':
                    this.precio_base += 80;
                    break;
                case 'C':
                    this.precio_base += 60;
                    break;
                case 'D':
                    this.precio_base += 50;
                    break;
                case 'E':
                    this.precio_base += 30;
                    break;
                case 'F':
                    this.precio_base += 10;
                    break;
            }

            if (this.peso >= 0 && this.peso <= 19)
            {
                this.precio_base += 10;
            }
            if (this.peso >= 20 && this.peso <= 49)
            {
                this.precio_base += 50;
            }
            if (this.peso >= 50 && this.peso <= 79)
            {
                this.precio_base += 80;
            }
            if (this.peso >= 80)
            {
                this.precio_base += 100;
            }

            return precio;
        }
    }

    class Lavadora : Electrodomestico
    {
        private double carga = 5;

        public Lavadora() : base() { }
        public Lavadora(int precio, float peso) : base(precio, peso) { }

        public Lavadora(int precio, string color, char consumo, double peso, double carga) : base(precio, color, consumo, peso)
        {
            this.carga = carga;
        }

        public double getCarga
        {
            get
            {
                return this.carga;
            }
        }

        public int precioFinal()
        {
            int precio = base.precioFinal();

            if (this.carga > 30)
            {
                precio += 50;
            }

            return precio;
        }
    }

    class Televisor : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintonizadorTDT = false;

        public Televisor() : base() { }

        public Televisor(int precio, double peso) : base(precio, peso) { }

        public Televisor(int precio, string color, char consumo, double peso, int resolucion, bool sintonizadorTDT) : base(precio, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public int getResolucion
        {
            get
            {
                return this.resolucion;
            }
        }

        public bool getSintonizadorTDT
        {
            get
            {
                return this.sintonizadorTDT;
            }
        }

        public int precioFinal()
        {
            int precio = base.precioFinal();

            if (this.resolucion > 40)
            {
                precio += (precio * 30) / 100;
            }
            if (this.sintonizadorTDT == true)
            {
                precio += 50;
            }

            return precio;
        }
    }

    class Ejecutable
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomestico = new Electrodomestico[10];

            electrodomestico[0] = new Lavadora(100000, "BLANCO", 'B', 100, 20);
            electrodomestico[1] = new Lavadora(90000, 95);
            electrodomestico[2] = new Lavadora(95000, 100);
            electrodomestico[3] = new Lavadora(15000, "GRIS", 'A', 120, 35);
            electrodomestico[4] = new Lavadora(90500, 10);
            electrodomestico[5] = new Televisor(100000, 14);
            electrodomestico[6] = new Televisor(85000, "NEGRO", 'b', 12, 40, true);
            electrodomestico[7] = new Televisor(100000, "AZUL", 'D', 10, 30, false);
            electrodomestico[8] = new Televisor(70000, "NEGRO", 'C', 10, 50, false);
            electrodomestico[9] = new Televisor(90000, "naranja", 'A', 10, 30, false);

            int lavadoraTotal = 0;
            int televisionTotal = 0;
            int posicionLavadora = 1;
            int posicionTelevision = 1;

            foreach (Electrodomestico e in electrodomestico)
            {
                if (e is Lavadora)
                {
                    lavadoraTotal += e.precioFinal();
                    Console.WriteLine("Lavadora " + posicionLavadora + ": " + e.precioFinal());
                    posicionLavadora++;
                }

                if (e is Televisor)
                {
                    televisionTotal += e.precioFinal();
                    Console.WriteLine("televisor " + posicionTelevision + ": " + e.precioFinal());
                    posicionTelevision++;
                }
            }

            int precioTotal = lavadoraTotal + televisionTotal;

            Console.WriteLine("\nPrecio total: {0}\nPrecio total de las lavadoras: {1}\nPrecio total de los televisores: {2}", precioTotal, lavadoraTotal, televisionTotal);

            Console.ReadKey();
        }
    }
}

