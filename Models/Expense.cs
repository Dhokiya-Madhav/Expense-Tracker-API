using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int userId { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string Category  { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
