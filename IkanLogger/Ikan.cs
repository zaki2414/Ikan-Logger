using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkanLogger
{
    public class Ikan
    {
        private int idIkan;
        private string namaIkan;
        private double hargaPasar;
        public int IdIkan
        {
            get { return idIkan; }
        }
        public string NamaIkan
        {
            get { return namaIkan; }
            set { namaIkan = value; }
        }

        public double HargaPasar
        {
            get { return hargaPasar; }
            set { hargaPasar = value; }
        }
        public void getInfoIkan()
        {
            // Mengambil info ikan dari database
        }
    }
}
