using Adapter.PaymentsMethods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PaymentsMethod
{
    public class LegacyPayment: ILegacyPaymentAdapter
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying $ {amount} using legacy payment method.");
        }

        public void Recieve(double amount)
        {
            Console.WriteLine($"Recieving $ {amount} using legacy payment method.");
        }

        public void Send(double amount)
        {
            Console.WriteLine($"Sending $ {amount} using legacy payment method.");
        }
    }
}
