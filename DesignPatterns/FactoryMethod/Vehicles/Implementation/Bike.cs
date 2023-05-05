namespace FactoryMethod.Vehicles.Implementation
{
    public class Bike : IVehicle
    {
        public void Deliver()
        {
            GetCargo();
            Console.WriteLine("Start route of transport...");
        }

        public void GetCargo()
        {
            Console.WriteLine("It is beginning transport of UberEats.");
        }
    }
}
