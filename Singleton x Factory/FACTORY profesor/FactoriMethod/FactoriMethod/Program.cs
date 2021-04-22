using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // IInmueble inmueble;//Variable de referencia
            Console.Clear();
            Console.Write("DE CUANTO DINERO DISPONE? ");
            int valor = int.Parse(Console.ReadLine());

            IInmueble inmueble = Fabrica.GetInmueble(valor);

            inmueble.Rentar();//¿El metodo Rentar(), de cual clase se esta llamando?

            Console.ReadKey();
            Main(args);

        }
    }
}
