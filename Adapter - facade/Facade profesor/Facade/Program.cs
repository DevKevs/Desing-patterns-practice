using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade fachada = new Facade();//Creando el objeto de tipo fachada

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1]Cuentas  [2]Prestamos  [3]Tarjetas   [4]Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        fachada.OperacionesCuentas();
                        break;
                    case 2:
                        fachada.OperacionessPrestamos();
                        break;
                    case 3:
                        fachada.OperacionesTarjetas();
                        break;
                }
            } while (opcion != 4);
        }
    }
}
