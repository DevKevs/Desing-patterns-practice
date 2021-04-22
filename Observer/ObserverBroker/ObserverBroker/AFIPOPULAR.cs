using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ObserverBroker
{
    class AFIPOPULAR : IObservador
    {
        
        public void Actualizar()
        {
            if (MercadoValores.Acciones < 100)
            {
                Console.WriteLine("Las acciones estan bajando...");
                Console.WriteLine("AFIPOPULAR va a COMPRAR acciones");
            }
        }
    }
}
