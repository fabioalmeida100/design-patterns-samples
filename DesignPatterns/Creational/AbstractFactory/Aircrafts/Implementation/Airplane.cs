namespace AbstractFactory.Aircrafts.Implementation
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checking wind... Wind it's ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passengers ok, flight allowed");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Starting the fly [Airplane]...");
            Console.WriteLine("- - - - - - - - - - - - - - -");
        }
    }
}
