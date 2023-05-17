using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IBuilder<T>
    {
        void Reset();
        T GetVehicle();
        void SetVehicleType(VehicleType vehicleType);
        void SetSeats(int seats);
        void SetEngine(Engine engine);

        void SetTransmissionType(TransmissionType transmissionType);
    }
}
