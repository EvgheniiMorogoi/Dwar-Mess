using FlowerShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FlowerShop.BusinessLogic.Interfaces;

namespace FlowerShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManager _manager;

        public HomeController(IManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var data = new HomeIndexViewModel()
            {
                TopProducts = _manager.productManager.GetFirstProducts(10).ToList(),
                TopServices = _manager.serviceManager.GetFirstServices(4).ToList()
            };
            return View(data);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}