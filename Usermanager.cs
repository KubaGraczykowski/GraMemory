using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMemory
{
    class Usermanager
    {
        string username;
        string password;

        public Usermanager(string username, string password)
        {
            this.username = username;
            this.password = password;
        }



        public void Login()
        {
            password = Console.ReadLine();
            username = Console.ReadLine();
        }
    }
}
