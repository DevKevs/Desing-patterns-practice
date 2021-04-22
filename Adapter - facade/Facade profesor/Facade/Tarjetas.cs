using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas
{
    class Tarjetas
    {

        private int numTarjeta;
        public Tarjetas(int num)
        {
            numTarjeta = num;
            
        }

        public void Pagar(double pago)
        {
            Console.WriteLine($"La tarjeta #{numTarjeta} ha recibido el pago de {pago}");
        }

        public void AvanceEfectivo(double monto, int cuenta)
        {
            Console.WriteLine($"Se han transferido {monto} a la cuenta {cuenta}");
        }
    }
}
