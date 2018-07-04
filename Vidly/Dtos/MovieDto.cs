using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime RelaseDate { get; set; }

        [Range(1, 20)]
        [Required]
        public byte NumberInStock { get; set; }

        [Required]
        public byte NumberAvaiable { get; set; }
    }
}