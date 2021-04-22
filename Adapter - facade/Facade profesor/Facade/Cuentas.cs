using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas

{
    class Cuentas
    {
        private int numCuenta;
        private double balance;
        public Cuentas(int num)
        {
            numCuenta = num;
        }

        public double Depositar(double monto)
        {
            balance += monto;
            return balance;
        }

        public double Retirar(double monto)
        {
            balance -= monto;
            return balance;
        }
    }
}
