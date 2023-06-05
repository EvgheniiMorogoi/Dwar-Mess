using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.Data.Models;
using FlowerShop.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IManager _manager;

        public OrdersController(IManager manager)
        {
            _manager = manager;
        }

        public IActionResult PlaceOrder()
        {
            return View(new NewOrderViewModel());
        }
        [Authorize]
        public IActionResult Orders()
        {
            var orders = _manager.orderManager.GetAllOrders();
            return View(orders);
        }

        [HttpPost]
        public IActionResult PaceOrder(NewOrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                if (!ModelState.IsValid)
                {
                    return View(order);
                }
                _manager.orderManager.AddOrder(
                    new Order()
                    {
                        ClientFullName = order.ClientFullName,
                        OrderDescription = order.OrderDescription,
                        OrderDate = DateTime.Now,
                        Email = order.Email,
                        Contacts = order.Contacts
                    });
                return RedirectToAction("ProductsIndex", "ProductAndService");
            }
            return View();
        }
    }
}
