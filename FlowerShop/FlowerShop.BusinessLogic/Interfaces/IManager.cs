using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Interfaces
{
    public interface IManager
    {
        IProductManager productManager { get; }
        IServiceManager serviceManager { get; }
        IOrderManager orderManager { get; }
    }
}
