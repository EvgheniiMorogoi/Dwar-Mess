using FlowerShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Interfaces
{
    public interface IOrderManager
    {
        void AddOrder(Order order);
        IEnumerable<Order> FindOrder(Func<Order, bool> predicate);
        Order GetOrder(int id);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetFirstOrders(int count);
    }
}
