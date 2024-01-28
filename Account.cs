using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class Account
    {
        public string Login;
        public int Password;
    }

    internal class Worker : Account
    {
        public int ID;
        public string Name;
    }
}
