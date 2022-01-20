using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternNet6.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
