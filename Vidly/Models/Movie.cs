using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [ForeignKey("Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name="Release Date")]
        [Column(TypeName ="datetime2")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }


    }
}