using FactoryMethod.Factories.Implementation;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your vehicle type: ");
            Console.WriteLine("1 - Car");
            Console.WriteLine("2 - Motorcycle");
            Console.WriteLine("3 - Bike (UberEats)");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    new CarTransport().CreateTransport();
                    break;
                case "2":
                    new MotorcycleTransport().CreateTransport();
                    break;
                case "3":
                    new BikeTransport().CreateTransport();
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }

            Console.ReadKey();
        }
    }
}