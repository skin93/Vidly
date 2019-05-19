﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }


    }
}