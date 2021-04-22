using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoriMethod
{
    class Fabrica
    {
        public static IInmueble GetInmueble(int alquiler)
        {
            if (alquiler <= 500)
            {
               return new Apartamento();
            }
            if (alquiler <= 999)
            {
                return new Casa();
            }
            if (alquiler <= 1999)
            {
                return new Villas();
            }
            else
            {
                return new Penthouse();
            }

        }
    }
}
