using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieYearViewModel
    {
        public List<Movie> movies;
        public SelectList years;
        public string movieYear { get; set; }
    }

    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 300)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}