using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eejer11
{
    internal class Pozo
    {
        private int saldo = 100;

        public Pozo() { }

        public Pozo(int saldo)
        {
            this.saldo = saldo;
        }

        public int getSaldo
        {
            get { return this.saldo; }
        }

        public void setSumarSaldo(int saldo) 
        {  
            this.saldo = this.saldo + saldo;
        }

        public void setRestarSaldo(int saldo)
        {
            this.saldo = this.saldo - saldo;
        }
    }
}
