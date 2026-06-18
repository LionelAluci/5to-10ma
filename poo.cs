using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IPagable
    {
        void ProcesarPago(decimal monto);
    }

    class TarjetaCredito : IPagable
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"procesando pago de : {monto}");
        }
    }

    class Paypal : IPagable
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"procesando pago de : {monto}");
        }
    }

    class CriptoMoneda : IPagable
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"procesando pago de : {monto}");
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            decimal montos = 500.00m;
            List<IPagable> MetodoPago = new List<IPagable>();
            {
                MetodoPago.Add(new TarjetaCredito());
                MetodoPago.Add(new CriptoMoneda());
                MetodoPago.Add(new Paypal());
            }

            foreach (IPagable pago in MetodoPago)
            {
                pago.ProcesarPago(montos);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
