using Bridge.Platforms.Interface;

namespace Bridge.Platforms
{
    public class YouTube : IPlatform
    {
        public YouTube()
        {
            Console.WriteLine("YouTube: transmission started...");
        }
        public void AuthToken()
        {
            Console.WriteLine("YouTube: autorization is ok.");
        }
        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: configuration of server RMTP.");
        }
    }
}
