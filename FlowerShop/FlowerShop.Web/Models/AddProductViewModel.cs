using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Web.Models
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product name")]
        [MinLength(5, ErrorMessage = "Product name must be at least 5 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Product price is required")]
        [Display(Name = "Product price")]
        public double PricePerUnit { get; set; }
        [Required(ErrorMessage = "Product description is required")]
        [Display(Name = "Product description")]
        [MinLength(20, ErrorMessage = "Product description must be at least 20 characters long")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Product image reference is required")]
        [Display(Name = "Product image reference")]
        public string Image { get; set; }
    }
}
