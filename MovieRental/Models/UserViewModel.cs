using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [MinLength(6)]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}