using FactoryMethod.Vehicles;
using FactoryMethod.Vehicles.Implementation;

namespace FactoryMethod.Factories.Implementation
{
    public class BikeTransport : TransportAbstract
    {
        protected override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
