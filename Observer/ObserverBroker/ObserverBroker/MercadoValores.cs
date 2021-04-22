using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBroker
{
    class MercadoValores
    {
        public static int Acciones { get; set; }//Propiedad que definira el estado

        public List<IObservador> brokers = new List<IObservador>();

        public void AgregarSub(IObservador observador)
        {
            brokers.Add(observador);

        }

        public void QuitarSub(IObservador observador)
        {
            brokers.Remove(observador);

        }

        public void Notificar()
        {

            foreach (var elemento in brokers)
            {
                elemento.Actualizar();
            }
        }


        //AGREGUE LAS FUNCIONALIDADES DE LA LOGICA DE NEGOCIO
        public void Operaciones(int valor)
        {
            Acciones = valor;
            Notificar();      
        }

        
    }
}
