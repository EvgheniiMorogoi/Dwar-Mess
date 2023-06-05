using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Interfaces
{
    public interface IProductManager
    {
        void AddProduct(Product product);
        IEnumerable<Product> FindProduct(Func<Product, bool> predicate);
        Product GetProduct(int id);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetFirstProducts(int count);
    }
}
