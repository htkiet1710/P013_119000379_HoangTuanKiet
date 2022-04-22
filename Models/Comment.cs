using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Emty;
        [Required]   
        public string Content { get; set; } = string.Emty;
        [Required]   
        public string CreatedAt { get; set; } = string.Emty;
    }
}