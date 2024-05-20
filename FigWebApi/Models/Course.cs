using System.ComponentModel.DataAnnotations;

namespace FigWebApi.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; } 

        [Required]
        public string? Description { get; set; } 

        [Required]
        public string? Instructor { get; set; } 

        public DateTime StartDate { get; set; }
    }
}
