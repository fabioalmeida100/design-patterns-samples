using Builder.Components;
using Builder.Products;

namespace Builder.Builders.Implementation
{
    public class VehicleBuilder : IBuilder<Vehicle>
    {
        private Vehicle _vehicle = new Vehicle();

        public void Reset()
        {
            _vehicle = new Vehicle();
        }
        Vehicle IBuilder<Vehicle>.GetVehicle()
        {
            return _vehicle;
        }

        public void SetEngine(Engine engine)
        {
            _vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            _vehicle.Seats = seats;
        }

        public void SetTransmissionType(TransmissionType transmissionType)
        {
            _vehicle.TransmissionType = transmissionType;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            _vehicle.VehicleType = vehicleType;
        }

    }
}
