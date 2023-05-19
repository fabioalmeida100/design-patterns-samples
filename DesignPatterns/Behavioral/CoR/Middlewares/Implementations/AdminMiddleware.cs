namespace ChainOfResponsability.Middlewares.Implementations
{
    public class AdminMiddleware: MiddlewareBase
    {
        private Server _server;

        public AdminMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Check(string email, string password)
        {
            if (_server.IsValidUser(email, password) && _server.IsAdmin(email))
            {
                Console.WriteLine("User is admin");
                return true;
            }

            return CheckNext(email, password);
        }

    }
}
