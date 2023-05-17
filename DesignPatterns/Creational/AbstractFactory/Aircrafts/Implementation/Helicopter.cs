using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts.Implementation
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checking wind... It is the wind ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Get passengers and fly...");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Starting the fly [Helicopter]...");
            Console.WriteLine("- - - - - - - - - - - - - - -");
        }
    }
}
