using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class Film
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        public string Genre { get; set; }

        [DataType(DataType.Currency), Range(1, 100)]
        public decimal Price { get; set; }

        /// <summary>
        /// add new property in model
        /// + update Controller, the binding white list for Create and Edit method
        /// + update View
        /// + Run PM> add-migration Rating -> update-database
        /// </summary>
        [StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        public string Rating { get; set; }
    }

    public class FilmDBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
    }
}