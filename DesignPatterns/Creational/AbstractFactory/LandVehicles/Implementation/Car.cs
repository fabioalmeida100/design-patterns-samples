namespace AbstractFactory.LandVehicles.Implementation
{
    public class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Get passengers and drive [Car]...");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Start route of transport...");
            Console.WriteLine("- - - - - - - - - - - - - - -");
        }
    }
}
