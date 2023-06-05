using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double PricePerUnit { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
