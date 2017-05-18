

using System.ComponentModel.DataAnnotations;
using System;
namespace VideoClub.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public byte GenderId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate  { get; set; }
        public byte  NumberInStock { get; set; }
    }
}