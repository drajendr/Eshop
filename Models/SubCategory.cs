using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Sub Category Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
