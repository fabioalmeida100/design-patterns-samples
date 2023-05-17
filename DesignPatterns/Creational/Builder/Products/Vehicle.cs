using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
    public class Vehicle
    {
        public VehicleType VehicleType { get; set; }
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public TransmissionType TransmissionType { get; set; }
    }
}
