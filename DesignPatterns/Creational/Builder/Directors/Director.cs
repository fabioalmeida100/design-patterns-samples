using Builder.Builders;
using Builder.Components;
using Builder.Products;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder<Vehicle> _builder;

        public Director(IBuilder<Vehicle> builder)
        {
            _builder = builder;
        }

        public Vehicle BuildVolvoTruck()
        {
            _builder.Reset();

            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetSeats(4);
            _builder.SetEngine(new Engine(720));
            _builder.SetTransmissionType(TransmissionType.SEMIAUTOMATIC);

            return _builder.GetVehicle();
        }

        public Vehicle BuildMotorCycleCB500Honda()
        {
            _builder.Reset();

            _builder.SetVehicleType(VehicleType.MOTORCYCLE);
            _builder.SetSeats(2);
            _builder.SetEngine(new Engine(500));
            _builder.SetTransmissionType(TransmissionType.MANUAL);

            return _builder.GetVehicle();
        }
    }
}
