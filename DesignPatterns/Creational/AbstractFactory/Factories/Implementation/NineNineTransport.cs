using AbstractFactory.Aircrafts;
using AbstractFactory.Aircrafts.Implementation;
using AbstractFactory.LandVehicles;
using AbstractFactory.LandVehicles.Implementation;

namespace AbstractFactory.Factories.Implementation
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
