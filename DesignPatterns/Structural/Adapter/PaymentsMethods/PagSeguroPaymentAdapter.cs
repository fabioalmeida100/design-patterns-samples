using Adapter.PaymentsMethods.Interfaces;

namespace Adapter.PaymentsMethods
{
    public class PagSeguroPaymentAdapter : ILegacyPaymentAdapter
    {
        private IPagSeguro _pagSeguro;

        public PagSeguroPaymentAdapter(IPagSeguro pagSeguro)
        {
            _pagSeguro = pagSeguro;
        }

        public void Pay(double amount)
        {
            _pagSeguro.Pagar(amount);
        }

        public void Recieve(double amount)
        {
            _pagSeguro.Receber(amount);
        }

        public void Send(double amount)
        {
            _pagSeguro.Enviar(amount);
        }
    }
}