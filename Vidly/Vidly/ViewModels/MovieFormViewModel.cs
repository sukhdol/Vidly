using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "The name of the movie is required.")]
        [StringLength(255, ErrorMessage = "The name of the movie cannot exceed 255 characters.")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "The release date is required.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required(ErrorMessage = "The number in stock is required.")]
        [Range(1, 20, ErrorMessage = "The number in stock must be between 1 and 20.")]
        public byte? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "The genre of the movie is required.")]
        public byte? GenreId { get; set; }

        // Dropdown list data
        public IEnumerable<Genre> Genres { get; set; }

        public string Heading
        {
            get { return Id != 0 ? "Edit Movie" : "Add Movie"; }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
        }
    }
}