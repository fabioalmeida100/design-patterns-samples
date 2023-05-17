using AbstractFactory.Aircrafts;
using AbstractFactory.Aircrafts.Implementation;
using AbstractFactory.LandVehicles;
using AbstractFactory.LandVehicles.Implementation;

namespace AbstractFactory.Factories.Implementation
{
    public class UberTransport : ITransportFactory
    {
        public IAircraft CreateAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
