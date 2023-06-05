using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Web.Models
{
    public class AddServiceViewModel
    {
        [Required(ErrorMessage = "Service name is required")]
        [Display(Name = "Service name")]
        [MinLength(5, ErrorMessage = "Service name must be at least 5 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Service description is required")]
        [Display(Name = "Service description")]
        [MinLength(20, ErrorMessage = "Service description must be at least 20 characters long")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Service image reference is required")]
        [Display(Name = "Service image reference")]
        public string Image { get; set; }
    }
}
