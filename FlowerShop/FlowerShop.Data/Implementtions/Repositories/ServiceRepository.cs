using FlowerShop.Data.Interfaces;
using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Implementtions.Repositories
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ApplicationDbContext appContext
        {
            get
            {
                return _context as ApplicationDbContext;
            }
        }

        public ServiceRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
