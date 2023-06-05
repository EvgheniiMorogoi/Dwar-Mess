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
    public class ServiceManager : IServiceManager
    {
        private readonly IUnitOfWork _unit;
        public ServiceManager(IUnitOfWork unit)
        {
            _unit = unit;
        }
        public void AddService(Service service)
        {
            _unit.Services.Add(service);
            _unit.Complete();
        }
        public IEnumerable<Service> FindOrder(Func<Service, bool> predicate)
        {
            return _unit.Services.Find(predicate);
        }
        public Service GetService(int id)
        {
            return _unit.Services.Get(id);
        }
        public IEnumerable<Service> GetAllService()
        {
            return _unit.Services.GetAll();
        }
        public IEnumerable<Service> GetFirstServices(int count)
        {
            return _unit.Services.GetFirst(count);
        }
    }
}
