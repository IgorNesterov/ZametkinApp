using System;
using System.Collections.Generic;
using System.Text;

namespace Zametkin
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User (String login, String password)
        {
            Login = login;
            Password = password;
        }
    }
}
