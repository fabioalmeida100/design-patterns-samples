namespace AbstractFactory.LandVehicles.Implementation
{
    public class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Get cargo and drive [Motorcycle]...");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Start route of transport...");
            Console.WriteLine("- - - - - - - - - - - - - - -");
        }
    }
}
