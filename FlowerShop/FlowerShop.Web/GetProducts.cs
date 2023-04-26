using FlowerShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShop.Web
{
     public class ProductRepository
     {
          public List<Flower> GetProducts()
          {
               // Retrieve products from a data store (e.g. a database)
               List<Flower> products = new List<Flower>
        {
            new Flower { Id = 1, Name = "Lalea", Description = "Da , s-au scumpit", Price = 35.0m },
            new Flower { Id = 2, Name = "Narcis", Description = "Cate 10 lei la babutze", Price = 10.0m },
            new Flower { Id = 3, Name = "Trandafir", Description = "Pentru mama", Price = 60.0m },
            // Add more products as needed
        };

               return products;
          }
     }

}