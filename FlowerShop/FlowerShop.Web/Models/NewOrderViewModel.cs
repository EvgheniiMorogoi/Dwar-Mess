using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Web.Models
{
    public class NewOrderViewModel
    {
        [Required(ErrorMessage = "Order description is required")]
        [Display(Name = "Order description")]
        public string OrderDescription { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Contacts are required")]
        [Display(Name = "Phone")]
        public string Contacts { get; set; }
        [Required(ErrorMessage = "Client full name is required")]
        [Display(Name = "Client full name ")]
        public string ClientFullName { get; set; }
    }
}
