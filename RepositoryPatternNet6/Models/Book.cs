using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternNet6.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; } 
        public decimal Price { get; set; }
        public string Genre { get; set; } = string.Empty;

        // Foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        public Author? Author { get; set; }
    }
}
