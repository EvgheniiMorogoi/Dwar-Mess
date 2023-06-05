using FlowerShop.Data.Interfaces;
using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Implementtions.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
