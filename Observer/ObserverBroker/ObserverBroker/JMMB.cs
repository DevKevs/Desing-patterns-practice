using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBroker
{
    class JMMB : IObservador
    {
        public void Actualizar()
        {
           

            if (MercadoValores.Acciones>=100 && MercadoValores.Acciones <= 199)
            {
                Console.WriteLine("Las acciones estan subiendo!!");
                Console.WriteLine("JMMB VENDIENDO acciones...");

            }
        }
    }
}
