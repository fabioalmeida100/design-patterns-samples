using Adapter.PaymentsMethod;
using Adapter.PaymentsMethods;
using Adapter.PaymentsMethods.Interfaces;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your payment method?");
            Console.WriteLine("1 - Legacy");
            Console.WriteLine("2 - PayPal");
            Console.WriteLine("3 - PagSeguro");

            var paymentMethod = Console.ReadLine();

            Console.WriteLine("How much do you want to pay?");
            var amount = Convert.ToDouble(Console.ReadLine());

            switch (paymentMethod)
            {
                case "1":
                    MakePayment(new LegacyPayment(), amount);
                    break;
                case "2":
                    MakePayment(new PayPalPaymentAdapter(new PayPalPayment()), amount);
                    break;
                case "3":
                    MakePayment(new PagSeguroPaymentAdapter(new PagSeguroPayment()), amount);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        static void MakePayment(ILegacyPaymentAdapter legacyPayment, double amount)
        {
            legacyPayment.Pay(amount);
        }
    }
}