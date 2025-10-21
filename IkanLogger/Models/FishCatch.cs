using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkanLogger.Models
{
    public class FishCatch
    {
        public int idFishCatch { get; set; }
        public double weight { get; set; }
        public Fish? idFish { get; set; }
        public CatchLog? idLog { get; set; }

        public void saveCatch()
        {
            // Simpan Catch ke database
        }

        public void updateCatch()
        {
            // Mengambil semua catch dari database
        }
        public void deleteCatch()
        {
            // Menghapus catch dari database
        }
    }
}
