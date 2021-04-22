using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeG2
{
    class Factura : ICloneable
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public DetalleFactura Detalle { get; set; }

        public object Clone()
        {
            Factura clon = (Factura)MemberwiseClone();//Clonamos superficial
            clon.Detalle = new DetalleFactura();
            clon.Detalle.Cliente = Detalle.Cliente;
            clon.Detalle.Monto = Detalle.Monto;
            return clon;

        }

      

        public override string ToString()
        {
            return $"{Id}, {Fecha}, {Detalle.Cliente}, {Detalle.Monto}";
        }

    }
}
