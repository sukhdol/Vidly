﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name of the movie is required.")]
        [StringLength(255, ErrorMessage = "The name of the movie cannot exceed 255 characters.")]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "The number in stock should be between 1 and 20")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "The genre of the movie is required.")]
        public byte GenreId { get; set; }

        // Navigation Properties
        public Genre Genre { get; set; }

    }
}