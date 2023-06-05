using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ClientFullName { get; set; }
        public string OrderDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public string Email { get; set; }
        public string Contacts { get; set; }
    }
}
