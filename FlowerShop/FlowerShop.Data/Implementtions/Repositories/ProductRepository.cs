using FlowerShop.Data.Implementtions.Repositories;
using FlowerShop.Data.Interfaces;
using FlowerShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Implementtions.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
