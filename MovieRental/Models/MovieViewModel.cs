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
        [Required(ErrorMessage = "A name is required")]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Range(1,120)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public string Price { get; set; }
    }
}
