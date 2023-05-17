using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles.Implementation
{
    public class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("It is beginning transport of passenger.");
        }

        public void Deliver()
        {
            GetCargo();
            Console.WriteLine("Start route of transport...");
        }
    }
}
