using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura();
            f1.Id = 1;
            f1.Fecha = "22/09/2020";
            f1.Detalle = new DetalleFactura();
            f1.Detalle.Cliente = "ANA";
            f1.Detalle.Monto = 500;

            //Factura f2 = f1; //"Supuesto Clone"
             Factura f2 = (Factura)f1.Clone(); //"Verdadero Clone"

            Console.WriteLine($"{f1.ToString()} *** {f2.ToString()}");
            Console.WriteLine(f1==f2);
            Console.WriteLine("-------");
            f2.Id = 51;
            f2.Fecha = "31/12/2050";
            f2.Detalle.Cliente = "PEDRO";
            f2.Detalle.Monto = 2000;
            Console.WriteLine($"{f1.ToString()} *** {f2.ToString()}");
            Console.ReadLine();

        }
    }
}
