using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Interfaces
{
    public interface IServiceManager
    {
        void AddService(Service service);
        IEnumerable<Service> FindOrder(Func<Service, bool> predicate);
        Service GetService(int id);
        IEnumerable<Service> GetAllService();
        IEnumerable<Service> GetFirstServices(int count);
    }
}
