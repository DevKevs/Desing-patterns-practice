using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBroker
{
    class GAMCAPITAL : IObservador
    {
        public void Actualizar()
        {
            if (MercadoValores.Acciones>=200)
            {
                Console.WriteLine("Las acciones estan subiendo!!!");
                Console.WriteLine("GAMCAPITAL va a VENDER acciones:");
            }
        }
    }
}
