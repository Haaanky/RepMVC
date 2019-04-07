using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepQuiz.Models
{
    public class Band
    {
        public int BandID { get; set; }
        public string BandName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string YouTubeLink { get; set; }
        public List<string> Albums { get; set; } = new List<string>();
    }
}
