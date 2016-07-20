using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "You need to provide the name of the genre.")]
        [StringLength(255, ErrorMessage = "The genre name cannot exceed 255 characters.")]
        public string Name { get; set; }
    }
}