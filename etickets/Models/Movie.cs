﻿using etickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Movie
    {
        private MovieCategory movieCategory;

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
