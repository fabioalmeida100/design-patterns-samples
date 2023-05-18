using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PaymentsMethods.Interfaces
{
    public interface IPayPal
    {
        void Checkout(double amount);

        void RecieveMoney(double amount);

        void SendMoney(double amount);
    }
}
