using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
        
        // Navigation Properties
        [Required(ErrorMessage = "The customer is required.")]
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "The movie is required.")]
        public Movie Movie { get; set; }
    }
}