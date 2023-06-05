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
    public class OrderManager : IOrderManager
    {
        private readonly IUnitOfWork _unit;
        public OrderManager(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void AddOrder(Order order)
        {
            _unit.Orders.Add(order);
            _unit.Complete();
        }
        public IEnumerable<Order> FindOrder(Func<Order, bool> predicate)
        {
            return _unit.Orders.Find(predicate);
        }
        public Order GetOrder(int id)
        {
            return _unit.Orders.Get(id);
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _unit.Orders.GetAll();
        }
        public IEnumerable<Order> GetFirstOrders(int count)
        {
            return _unit.Orders.GetFirst(count);
        }
    }
}
