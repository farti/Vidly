using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Relase Date")]
        public DateTime RelaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        public byte NumberInStock { get; set; }

        public byte NumberAvaiable { get; set; }
    }
}