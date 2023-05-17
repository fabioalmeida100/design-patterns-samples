using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Implementation;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your option: ");
            Console.WriteLine("1 - Uber");
            Console.WriteLine("2 - 99");
            var vehicle = Console.ReadLine();
            ITransportFactory? _transportFactory = null;

            switch (vehicle)
            {
                case "1":
                    _transportFactory = new UberTransport();
                    break;
                case "2":
                    _transportFactory = new NineNineTransport();
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }

            if (_transportFactory != null)
            {
                var transportClient = new TransportClient(_transportFactory);
                transportClient.StartRoute();
            }

            Console.ReadKey();
        }
    }
}