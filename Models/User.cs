using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class User
    {
        
        [Required]
        public int Id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Monthly_Budget { get; set; }
    }
}
