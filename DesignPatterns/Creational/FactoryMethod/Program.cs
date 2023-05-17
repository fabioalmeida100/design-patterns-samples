using FactoryMethod.Factories.Implementation;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o tipo de transporte: ");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
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
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}