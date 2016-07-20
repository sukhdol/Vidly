using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to provide the name of the movie.")]
        [StringLength(255, ErrorMessage = "The name of the movie cannot exceed 255 characters.")]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }

        public byte GenreId { get; set; }

        // Navigation Properties
        [Required(ErrorMessage = "You need to provide a genre.")]
        public Genre Genre { get; set; }

    }
}