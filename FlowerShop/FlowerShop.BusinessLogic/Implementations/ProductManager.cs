using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.Data.Interfaces;
using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Implementations
{
    public class ProductManager : IProductManager
    {
        private readonly IUnitOfWork _unit;
        public ProductManager(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void AddProduct(Product product)
        {
            _unit.Products.Add(product);
            _unit.Complete();
        }
        public IEnumerable<Product> FindProduct(Func<Product, bool> predicate)
        {
            return _unit.Products.Find(predicate);
        }
        public Product GetProduct(int id)
        {
            return _unit.Products.Get(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _unit.Products.GetAll();
        }
        public IEnumerable<Product> GetFirstProducts(int count)
        {
            return _unit.Products.GetFirst(count);
        }
    }
}
