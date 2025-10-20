using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IkanLogger.Models
{
    public class User
    {
        public int idUser { get; set; }
        public string? userName { get; set; }
        public string? userPassword { get; set; }

        public Boolean Login(string userName, string userPassword)
        {
            // User login
            return true;
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