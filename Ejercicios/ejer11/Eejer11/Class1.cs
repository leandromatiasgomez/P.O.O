using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eejer11
{
    internal class Jugadores
    {
        private string nombre;
        private int saldo;
        private int resultadoEquipoA;
        private int resultadoEquipoB;
        private bool permisoParaJugar = false;
        private int cantidadGanadas = 0;

        public Jugadores() { }

        public Jugadores(string nombre, int saldo, int resultadoEquipoA, int resultadoEquipoB, bool permisoParaJugar, int cantidadGanadas)
        {
            this.nombre = nombre;
            this.saldo = saldo;
            this.resultadoEquipoA = resultadoEquipoA;
            this.resultadoEquipoB = resultadoEquipoB;
            this.permisoParaJugar = permisoParaJugar;
            this.cantidadGanadas = cantidadGanadas;
        }

        public string getNombre
        {
            get { return this.nombre; }
        }

        public int getSaldo
        {
            get { return this.saldo; }  
        }

        public int getResultadoEquipoA
        {
            get { return this.getResultadoEquipoA;  }
        }

        public int getResultadoEquipoB
        {
            get { return this.getResultadoEquipoB; }
        }

        public bool getPermisoParaJugar
        {
            get { return this.permisoParaJugar; }
        }

        public int getCantidadGanadas
        {
            get { return this.cantidadGanadas;  }
        }

        public void setSumarSaldo(int saldo)
        {
            this.saldo = this.saldo + saldo;
        }

        public void setRestarSaldo (int saldo)
        {
            this.saldo =  this.saldo - saldo;
        }

        public void setPermisoParaJugar (bool permiso)
        {
            this.permisoParaJugar = permiso;
        }

        public void setCantidadGanadas(int victoria)
        {
            this.cantidadGanadas = this.cantidadGanadas + victoria;
        }
    }
}
