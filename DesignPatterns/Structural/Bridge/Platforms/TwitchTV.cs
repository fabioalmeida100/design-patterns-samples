using Bridge.Platforms.Interface;

namespace Bridge.Platforms
{
    public class TwitchTV: IPlatform
    {
        public TwitchTV()
        {
            Console.WriteLine("TwitchTV: transmission started.");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: autorization is ok.");
        }
        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: configuration of server RMTP.");
        }
    }
}
