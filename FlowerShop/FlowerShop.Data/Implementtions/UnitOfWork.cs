using FlowerShop.Data.Implementtions.Repositories;
using FlowerShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Implementtions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
            Services = new ServiceRepository(_context);
        }
        public OrderRepository Orders { get; private set; }

        public ProductRepository Products { get; private set; }

        public ServiceRepository Services { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
