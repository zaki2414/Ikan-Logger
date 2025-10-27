using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IkanLogger.Models
{
    public class User
    {
        public int idUser = 0;
        public string userName = string.Empty;
        public string userPassword = string.Empty;

        public User() { }
        public User(string username, string password) 
        {
            userName = username;
            userPassword = password;
        }

        public Boolean Login(string userName, string userPassword)
        {
            if (userName == "admin" && userPassword == "admin")
            {
                idUser = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            // User logout
        }

        public void Register(string userName, string userPassword)
        {
            // User registration
        }
    }
}