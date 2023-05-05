using FactoryMethod.Vehicles;
using FactoryMethod.Vehicles.Implementation;

namespace FactoryMethod.Factories.Implementation
{
    public class MotorcycleTransport : TransportAbstract
    {
        protected override IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
