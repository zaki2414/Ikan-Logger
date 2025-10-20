using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkanLogger.Models
{
    public class Fish
    {
        public int IdFish { get; set; }
        public string? fishName { get; set; }
        public double marketPrice { get; set; }
        public Location? idLocation { get; set; }

        public void getInfoFish()
        {
            // Mengambil info ikan dari database
        }
    }
}
