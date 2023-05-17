using FactoryMethod.Vehicles;
using FactoryMethod.Vehicles.Implementation;

namespace FactoryMethod.Factories.Implementation
{
    public class CarTransport: TransportAbstract
    {
        protected override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
