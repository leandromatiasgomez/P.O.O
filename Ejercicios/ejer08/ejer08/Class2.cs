using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
    internal class Profesor : IPrecencia
    {
        private string nombre;
        private int edad;
        private char sexo;
        private string materia;
        private int faltas;
        private bool presente = false;

        public Profesor(string nombre, int edad, char sexo, string materia, int faltas, bool presente)
        {
            this.nombre = nombre;
            this.edad = edad;
            comprobarSexo(sexo);
            comprobarMaterias(materia);
            this.faltas = faltas;
            this.presente = presente;
        }

        public void comprobarMaterias(string materia)
        {
            string materiasPosibles = "MATEMATICASFILOSOFIAFISICA";

            if (materiasPosibles.Contains(materia.ToUpper()))
            {
                this.materia = materia;
            }
            else
            {
                this.materia = "Matematicas";
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

            if (ausentismo < 20)
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
