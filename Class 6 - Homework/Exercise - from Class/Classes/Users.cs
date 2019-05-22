using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___from_Class.Classes
{
    class Users
    {
        public static int index = 1;

        public string Username;
        public string Password;
        public int id;


        public Users(string username, string password)
        {
            Username = username;
            Password = password;
            id = index++;
        }

        public int GetId()
        {
            return id;
        }

        public Users()
        {

        }
    }
}
