using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PaymentsMethods.Interfaces
{
    public interface IPagSeguro
    {
        void Pagar(double valor);

        void Receber(double valor);

        void Enviar(double valor);
    }
}
