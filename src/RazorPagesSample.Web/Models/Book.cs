using System;

namespace RazorPagesSample.Web.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
    }
}