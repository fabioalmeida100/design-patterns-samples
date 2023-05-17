using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory
{
    public class TransportClient
    {
        private ILandVehicle _vehicle;
        private IAircraft _aircraft;
        
        public TransportClient(ITransportFactory factory)
        {
            _vehicle = factory.CreateVehicle();
            _aircraft = factory.CreateAircraft();
        }

        public void StartRoute()
        {
            _vehicle.StartRoute();
            _aircraft.StartRoute();
        }
    }
}
