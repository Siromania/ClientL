using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Client.Model
{
    class User
    {

        private string login;
        private string password;
        private string tokenUser;
        private bool connect;

        public User(string l,string p)
        {
            login = l;
            password = p;
        }

        public User(string l, string p, string t)
        {
            login = l;
            password = p;
            tokenUser = t;
        }

        public string Password { get => password; set => password = value; }
        public string TokenUser { get => tokenUser; set => tokenUser = value; }
        public bool Connect { get => connect; set => connect = value; }
        public string Login { get => login; set => login = value; }
    }
}
