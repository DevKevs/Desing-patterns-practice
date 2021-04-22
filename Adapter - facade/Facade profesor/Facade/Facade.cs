using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemas;

namespace Facade
{
    class Facade
    {
        //Variables de referencia
        private Prestamos presta;
        private Cuentas cuenta;
        private Tarjetas tarjeta;

        #region OpsPrestamos
        public void OperacionessPrestamos()
        {
            Console.WriteLine("***SOLICITUD DE PRESTAMO***");
            Console.Write("Digite el monto: ");
            double monto = double.Parse(Console.ReadLine());
            Console.Write("Digite la tasa: ");
            double tasa = double.Parse(Console.ReadLine());
            presta = new Prestamos(monto, tasa);//Creando el objeto de tipo Prestamos
            presta.AprobarPrestamo();
            Console.ReadKey();
                       
            
        }
        #endregion

        #region Cuentas
        public void OperacionesCuentas()
        {
            double balance;

            Console.Write("Digite su # de cuenta: ");
            int num = int.Parse(Console.ReadLine());
            cuenta = new Cuentas(num);//Creo el objeto
            Console.WriteLine("[1]Deposito  [2]Retiro");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Diga el monto: ");
                double monto = double.Parse(Console.ReadLine());
                balance = cuenta.Depositar(monto);//Accedo al metodo de la clase cuenta
                Console.Write($"Su balance es: {balance}");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Diga el monto:");
                double monto = double.Parse(Console.ReadLine());
                balance = cuenta.Retirar(monto);//Accedo al otro metodo de la clase cuenta
                Console.Write($"Su balance es: {balance}");
                Console.ReadKey();
            }
            
        }
        #endregion

        #region OpsTarjetas
        public void OperacionesTarjetas()
        {
            double monto;

            Console.Write("Diga el # de la tarjeta: ");
            int num = int.Parse(Console.ReadLine());
            tarjeta = new Tarjetas(num);//Creamos el objeto tarjeta
            Console.Write("Cuanto va a pagar: ");
            monto = double.Parse(Console.ReadLine());
            tarjeta.Pagar(monto);//Usamos la funcionalidad de la tarjeta



            Console.ReadKey();

        }
        #endregion
    }
}
