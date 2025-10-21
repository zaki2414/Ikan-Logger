using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IkanLogger.Models
{

    public class Location
    {
        public int IdLocation { get; set; }
        public string? coordinate { get; set; }
        public List<Fish> FishList { get; set; } = new List<Fish>();

        public List<Fish> GetFishList()
        {
            return FishList;
        }
    }
}   