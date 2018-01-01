using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Range(1,120)]
        public string Price { get; set; }
    }
}
