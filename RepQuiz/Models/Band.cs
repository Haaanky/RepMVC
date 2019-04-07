using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepQuiz.Models
{
    public class Band
    {
        public int ID { get; set; }
        [Display(Name = "Band Name")]
        [Required(ErrorMessage = "Enter a Band Name")]
        public string BandName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [StringLength(10, ErrorMessage = "Must be between 4 to 10 characters", MinimumLength = 10)]
        public string YouTubeLink { get; set; }
        public List<string> Albums { get; set; } = new List<string>();
    }
}
