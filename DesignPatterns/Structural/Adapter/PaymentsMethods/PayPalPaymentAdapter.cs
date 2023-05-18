using Adapter.PaymentsMethods.Interfaces;

namespace Adapter.PaymentsMethods
{
    public class PayPalPaymentAdapter : ILegacyPaymentAdapter
    {
        private IPayPal _payPal;

        public PayPalPaymentAdapter(IPayPal payPal)
        {
            _payPal = payPal;
        }

        public void Pay(double amount)
        {
            _payPal.Checkout(amount);
        }

        public void Recieve(double amount)
        {
            _payPal.RecieveMoney(amount);
        }

        public void Send(double amount)
        {
            _payPal.SendMoney(amount);
        }
    }
}
