using Singleton.Utils;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration1 = Utils.ConfigurationSingletonHelper.GetInstance();
            Console.WriteLine("ConnectionString sample: " + configuration1.GetConnectionString());
            Console.WriteLine("Other configuration sample: " + configuration1.GetOtherConfiguration("key"));

            var configuration2 = Utils.ConfigurationSingletonHelper.GetInstance();
            Console.WriteLine("Is real singleton: " + (configuration1 == configuration2));
        }
    }
}