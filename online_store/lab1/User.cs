using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class User
    {
        private string login;
        private string password;

        public User()
        {

        }

        public string getUserPass()
        {
            return password;
        }

        public string getUserLogin()
        {
            return login;
        }

        public string setUserPass(string password_inp)
        {
            return password = password_inp;
        }

        public string setUserLogin(string login_inp)
        {
            return login = login_inp;
        }

    }
}
