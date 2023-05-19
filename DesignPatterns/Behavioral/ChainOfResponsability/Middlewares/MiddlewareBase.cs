using System.Net.Security;

namespace ChainOfResponsability.Middlewares
{
    public abstract class MiddlewareBase
    {
        private MiddlewareBase _next;

        public MiddlewareBase NextMiddleware(MiddlewareBase next)
        {
            _next = next;
            return next;
        }

        public abstract bool Check(string email, string password); // This is the handle() method: it must be implemented by all concrete handlers

        protected bool CheckNext(string email, string password)
        {
            if (_next == null)
                return true;

            return _next.Check(email, password);
        }
    }
}
