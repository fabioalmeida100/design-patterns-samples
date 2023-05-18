using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PaymentsMethods.Interfaces
{
    public interface ILegacyPaymentAdapter
    {
        void Pay(double amount);

        void Recieve(double amount);

        void Send(double amount);
    }
}
