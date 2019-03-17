using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesSample.Web.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Slug { get; set; }

        [Required]
        public string Author { get; set; }

        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
    }
}