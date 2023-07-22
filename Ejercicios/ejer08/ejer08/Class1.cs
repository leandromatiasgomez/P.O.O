using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
    internal class Estudiantes:IPrecencia
    {
        private string nombre;
        private int edad;
        private char sexo;
        private int nota;
        private int faltas;
        private bool presente = false;

        public Estudiantes(string nombre, int edad, char sexo, int nota, int faltas, bool presente)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            comprobarNota(nota);
            this.faltas = faltas;
            this.presente = presente;
        }

        public void comprobarNota(int nota)
        {
            if (nota < 0)   
            {
                this.nota = 0;
            }
            else if (nota > 10)
            {
                this.nota = 10;
            }
            else
            {
                this.nota = nota;
            }
        }

        public void comprobarSexo(char sexo)
        {
            string sexosPosibles = "MF";

            if (sexosPosibles.Contains(sexo))
            {
                this.sexo = sexo;
            }
            else 
            { 
                this.sexo = 'M'; 
            }
        }

        public string precencia(int faltas, int diasDeClases)
        {
            int ausentismo = (faltas * diasDeClases) / 100;

            if (ausentismo < 50)
            {
                return ("Puede faltar");
            }
            else
            {
                return ("No puede faltar");
            }
        }

    }
}
