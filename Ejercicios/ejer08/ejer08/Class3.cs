using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
    internal class Aulas
    {
        private int numeroDeAula;
        private int capacidad;
        private string materia;

        public Aulas(int numeroDeAula, int capacidad, string materia)
        {
            this.numeroDeAula = numeroDeAula;
            this.capacidad = capacidad;
            comprobarMateria(materia);
        }

        public void comprobarMateria(string materia)
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

        

    }
}
