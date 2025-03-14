using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2.Task3
{
    public class Authenticator
    {
        private static Authenticator instance;
        private static readonly object lockObject = new object();
        private Authenticator() { }
        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }
        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticating {username} with password {password}");
        }
        public void Show()
        {
            Console.WriteLine("Це єдиний екземпляр класу!");
        }

    }
}
