using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Server
    {
        private readonly Dictionary<string, string> _users = new Dictionary<string, string>();
        private MiddlewareBase _middleware;

        public void SetMiddleware(MiddlewareBase middleware)
        {
            _middleware = middleware;
        }

        public bool LogIn(string email, string password)
        {
            if (_middleware.Check(email, password))
            {
                Console.WriteLine("You're logged! Welcome to the system :-)");
                return true;
            }
            return false;
        }
        public void RegisterUser(string email, string password)
        {
            _users[email] = password;
        }

        public bool IsValidUser(string email, string password)
        {
            return _users.ContainsKey(email) && _users[email] == password;
        }

        public bool IsAdmin(string email)
        {
            return email == "fabioalmeida@fabiodeveloper.com";
        }
    }
}
