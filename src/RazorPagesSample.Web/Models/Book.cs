using System;

namespace RazorPagesSample.Web.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        // TODO: add image
    }
}