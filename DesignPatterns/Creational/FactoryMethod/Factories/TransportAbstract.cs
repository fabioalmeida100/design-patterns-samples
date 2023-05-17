using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public abstract class TransportAbstract
    {
        protected abstract IVehicle CreateVehicle();

        public void CreateTransport()
        {
            var vehicle = CreateVehicle();
            vehicle.Deliver();
        }
    }
}
