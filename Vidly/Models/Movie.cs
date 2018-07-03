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

     
        [DataType(DataType.DateTime)]
        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; }

       
        [DataType(DataType.DateTime)]
        [Display(Name = "Relase Date")]
        public DateTime RelaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte NumberInStock { get; set; }

        [Display(Name = "Number Avaiable")]
        [Required]
        public byte NumberAvaiable { get; set; }
    }
}