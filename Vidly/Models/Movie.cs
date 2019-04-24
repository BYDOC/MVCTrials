using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Movie Name")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public Genre Genre { get; set; }

        [Display(Name ="Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name ="Date Added")]
        public DateTime? DateAdded { get; set; }

        [Display(Name ="Number In Stock")]
        public byte NumberInStock { get; set; }

        [Required]
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }
    }
}
