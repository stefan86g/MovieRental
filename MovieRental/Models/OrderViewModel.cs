using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class OrderViewModel
    {
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime OrderDate { get; set; }
    }
}