using Adapter.PaymentsMethods.Interfaces;

namespace Adapter.PaymentsMethods
{
    public class PagSeguroPayment : IPagSeguro
    {
        public void Enviar(double valor)
        {
            Console.WriteLine($"Send money to PagSeguro $ {valor}");
        }

        public void Pagar(double valor)
        {
            Console.WriteLine($"Pay with PagSeguro $ {valor}");
        }

        public void Receber(double valor)
        {
            Console.WriteLine($"Recieve money from PagSeguro $ {valor}");
        }
    }
}
