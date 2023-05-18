using Bridge.Platforms;
using Bridge.Platforms.Interface;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which platform do you want to use?");
            Console.WriteLine("1 - Facebook");
            Console.WriteLine("2 - TwitchTV");
            Console.WriteLine("3 - YouTube");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Live(new Facebook());
                    break;
                case "2":
                    Live(new TwitchTV());
                    break;
                case "3":
                    Live(new YouTube());
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.ReadLine();
        }

        private static void Live(IPlatform platform)
        {
            var live = new Live(platform);
            live.Broadcast();
            live.Result();
        }
    }
}