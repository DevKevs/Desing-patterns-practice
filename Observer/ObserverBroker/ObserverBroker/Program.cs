using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBroker
{
    class Program
    {
        static void Main(string[] args)
        {
            MercadoValores bolsa = new MercadoValores();//Sujeto
           
            GAMCAPITAL gamCap = new GAMCAPITAL(); //Observadoras
            AFIPOPULAR afiPop = new AFIPOPULAR();
            JMMB jm = new JMMB();

            bolsa.AgregarSub(gamCap);
            bolsa.AgregarSub(afiPop);
            bolsa.AgregarSub(jm);
           

            bolsa.Operaciones(150);
            
            Console.ReadKey();

            bolsa.QuitarSub(gamCap);

            bolsa.Operaciones(350);
            bolsa.Operaciones(50);
            bolsa.Operaciones(120);

            Console.ReadKey();
        }
    }
}
