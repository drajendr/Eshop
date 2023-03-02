using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}