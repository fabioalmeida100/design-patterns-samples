namespace ChainOfResponsability.Middlewares.Implementations
{
    public class AutenticationMiddleware : MiddlewareBase
    {
        private Server _server;

        public AutenticationMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Check(string email, string password)
        {
            if (_server.IsValidUser(email, password))
            {
                Console.WriteLine("User is valid");
                return CheckNext(email, password);
            }

            return false;
        }
    }
}
