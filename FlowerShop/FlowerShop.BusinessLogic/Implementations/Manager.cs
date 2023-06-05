using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Implementations
{
    public class Manager : IManager
    {
        public Manager(IUnitOfWork unit)
        {
            productManager = new ProductManager(unit);
            serviceManager = new ServiceManager(unit);
            orderManager = new OrderManager(unit);
        }
        public IProductManager productManager { get; private set; }

        public IServiceManager serviceManager { get; private set; }

        public IOrderManager orderManager { get; private set; }
    }
}
