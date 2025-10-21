namespace IkanLogger
{
    public class User
    {
        private int idUser;
        private string nama;
        private string password;

     public int IdUser
        {
            get { return idUser; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Boolean Login(string nama, string password)
        {
            if (nama == "admin" && password == "admin")
            {
                this.idUser = 1;
                this.nama = nama;
                this.password = password;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}