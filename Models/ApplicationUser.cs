using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Pincode")]
        public int Pincode { get; set; }
    }
}
