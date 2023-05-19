using ChainOfResponsability;
using ChainOfResponsability.Middlewares.Implementations;

namespace CoR
{
    internal class Program
    {
        private static Server _server;

        static void Main(string[] args)
        {
            InitServer();

            Console.WriteLine("Enter your email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();

            if (!_server.LogIn(email, password))
                Console.WriteLine("Invalid credentials");

            Console.ReadLine();

        }

        static void InitServer()
        {
            _server = new Server();
            _server.RegisterUser("carlos@gmail.com", "123456");
            _server.RegisterUser("ana@hotmail.com", "52489");
            _server.RegisterUser("fabioalmeida@fabiodeveloper.com", "up2023");

            var middleware = new AutenticationMiddleware(_server);
            middleware.NextMiddleware(new AdminMiddleware(_server));

            _server.SetMiddleware(middleware);
        }
    }
}