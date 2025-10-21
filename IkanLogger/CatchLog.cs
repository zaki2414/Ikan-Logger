using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkanLogger
{
    public class CatchLog
    {
        private int idLog;
        private DateTime tanggal;
        private string jenisIkan;
        private double totalBerat;
        private string lokasiTangkap;

        public int IdLog
        {
            get { return idLog; }
        }
        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }
        public string JenisIkan
        {
            get { return jenisIkan; }
            set { jenisIkan = value; }
        }
        public double TotalBerat
        {
            get { return totalBerat; }
            set { totalBerat = value; }
        }
        public string LokasiTangkap
        {
            get { return lokasiTangkap; }
            set { lokasiTangkap = value; }
        }
        public void saveLog()
        {
            // Simpan Log ke database
        }

        public void getAllLog() 
        {
            // Mengambil semua log dari database
        }

        public void getLogbyDate(DateTime tanggal) 
        {
            // Mengambil log berdasarkan tanggal
        }

        public void getLogbyLocation(string lokasiTangkap) 
        {
            // Mengambil log berdasarkan lokasi tangkap
        }
    }
}
