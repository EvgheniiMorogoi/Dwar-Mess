using FlowerShop.Data.Implementtions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Interfaces
{
    public interface IUnitOfWork
    {
        OrderRepository Orders { get; }
        ProductRepository Products { get; }
        ServiceRepository Services { get; }
        int Complete();
    }
}
