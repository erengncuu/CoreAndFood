using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name not be empty")]
        [StringLength(20,ErrorMessage ="Please only enter 4-20 characters",MinimumLength =4)]
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

        public List<Food> Foods { get; set; }
    }
}
