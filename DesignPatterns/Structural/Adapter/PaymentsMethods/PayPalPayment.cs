using Adapter.PaymentsMethods.Interfaces;

namespace Adapter.PaymentsMethods
{
    public class PayPalPayment : IPayPal
    {
        public void Checkout(double amount)
        {
            Console.WriteLine($"Payment was made with PayPal: $ {amount}");
        }

        public void RecieveMoney(double amount)
        {
            Console.WriteLine($"Recieved money from PayPal: {amount}");
        }

        public void SendMoney(double amount)
        {
            Console.WriteLine($"Sent money to PayPal: {amount}");
        }
    }
}
