using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }        
        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }
        [Required]
        [Display(Name = "Product Category")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public Category Category { get; set; }
        [Required]
        [Display(Name = "Sub Category")]
        public int ProductSubCategoryId { get; set; }
        [ForeignKey("ProductSubCategoryId")]
        public SubCategory SubCategory { get; set; }
    }
}
