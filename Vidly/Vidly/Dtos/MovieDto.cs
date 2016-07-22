using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name of the movie is required.")]
        [StringLength(255, ErrorMessage = "The name of the movie cannot exceed 255 characters.")]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20, ErrorMessage = "The number in stock should be between 1 and 20")]
        public byte NumberInStock { get; set; }

        [Required(ErrorMessage = "The genre of the movie is required.")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}