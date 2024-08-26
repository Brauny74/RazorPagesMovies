﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prince { get; set; }

        public string Rating { get; set; }
    }
}
