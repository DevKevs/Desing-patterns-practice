using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas
{
    class Prestamos
    {
        private int numPrestamo;
        private double montoPrestamo;
        private double tasaPrestamo;
        Random aleatorio = new Random();

        public Prestamos(double monto, double tasa)
        {
            numPrestamo = aleatorio.Next(1001, 9999);
            montoPrestamo = monto;
            tasaPrestamo = tasa;
        }

       
        public void AprobarPrestamo()
        {
            Console.WriteLine($"***Prestamo aprobado:***\n" +
                $"Numero prestamo: #{numPrestamo} \n" +
                $"Monto: {montoPrestamo} \n" +
                $"Tasa: {tasaPrestamo}%");
            
        }

     }
}
