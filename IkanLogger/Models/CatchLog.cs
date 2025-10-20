using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkanLogger.Models
{
    public class CatchLog
    {
        public int IdLog { get; set; }
        public DateTime dateTime { get; set; }
        public string? notes    { get; set; }
        public User? user { get; set; }
        public Location? location { get; set; }



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
