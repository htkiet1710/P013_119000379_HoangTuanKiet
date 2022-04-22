using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class News
    {
        public int Id { get; set; }  
        public string Title { get; set; } = string.Emty;
        [MaxLength(200)]
        [MinLength(50)]
        [Required]   

        [System.ComponentModel.Bindable(true)]
        public virtual string ImageUrl { get; set; } = string.Emty;

        public decimal Content { get; set; }
        [MaxLength(500)]
        [MinLength(100)]
        [Required] 
        public string Author { get; set; } = string.Emty;
        [Required] 
        public string CreatedAt { get; set; } = string.Emty;
    }
}