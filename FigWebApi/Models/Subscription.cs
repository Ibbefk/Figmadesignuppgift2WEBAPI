using System.ComponentModel.DataAnnotations;

namespace FigWebApi.Models
{
    public class Subscription
    {
        [Key]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
