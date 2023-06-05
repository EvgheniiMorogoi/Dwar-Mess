using FlowerShop.Data.Models;

namespace FlowerShop.Web.Models
{
    public class HomeIndexViewModel
    {
        public List<Product> TopProducts { get; set; }
        public List<Service> TopServices { get; set; }
    }
}
