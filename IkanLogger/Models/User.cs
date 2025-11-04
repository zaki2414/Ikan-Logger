using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace IkanLogger.Models
{
    public class User
    {
        private int id;
        private string userName;
        private string userPassword ;
        private string email;

        private string connString = "Host=db.ihgmwmzlforobjkjxxqg.supabase.co;" +
                                    "Port=5432;Username=postgres;" +
                                    "Password=HLSvizxbIpMIKSrZ;" +
                                    "Database=postgres;" +
                                    "SSL Mode=Require;Trust Server Certificate=true";

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }

        public string Email
        {
            get { return email; }
            private set { email = value; }
        }

        public User(string username, string password) 
        {
            userName = username;
            userPassword = password;
        }

        public bool Login(string identifier, string password)
        {
            // User Login
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = @"select * from login_user(:_identifier, :_password)";
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("_identifier", identifier);
            cmd.Parameters.AddWithValue("_password", password);

            int loginResult = Convert.ToInt32(cmd.ExecuteScalar());

            if (loginResult > 0)
            {
                // login sukses
                Id = loginResult;
                return true;
            }
            else
            {
                // login gagal
                return false;
            }
        }

        public bool Register(string username,string email, string password)
        {
            // User registration
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = @"select * from register_user(:_username, :_email, :_password)";
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("_username", username);
            cmd.Parameters.AddWithValue("_email", email);
            cmd.Parameters.AddWithValue("_password", password);

            var result = cmd.ExecuteScalar();
            return Convert.ToInt32(result) == 1;
        }

        public bool GetProfile(int id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string sql = @"SELECT * FROM get_user_profile(:_id)";
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("_id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                userName = reader["username"].ToString();
                email = reader["email"].ToString();
                return true;
            }
            return false;
        }
    }
}