using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manicure
{
    public class Account
    {
        public string username;
        public string password;
        public string email;
        public string admin;

        public Account(string username,string password,string email,string admin)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.admin = admin;
        }

    }
}
