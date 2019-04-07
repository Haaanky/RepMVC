using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepQuiz.Models
{
    public class Band
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter a Band Name")]
        public string BandName { get; set; }
        [Required(ErrorMessage ="Enter a description")]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string YouTubeLink { get; set; }
        public List<string> Albums { get; set; } = new List<string>();
    }
}
