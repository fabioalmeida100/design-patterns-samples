using Bridge.Platforms.Interface;

namespace Bridge.Platforms
{
    public class Facebook: IPlatform
    {
        public Facebook()
        {
            Console.WriteLine("Facebook: transmission started...");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorization is ok.");
        }
        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configuration of server RMTP.");
        }
    }
}
