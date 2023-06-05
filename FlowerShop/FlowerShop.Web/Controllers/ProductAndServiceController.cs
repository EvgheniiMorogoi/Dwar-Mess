using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.Data.Models;
using FlowerShop.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Web.Controllers
{
    public class ProductAndServiceController : Controller
    {
        private readonly IManager _manager;
        public ProductAndServiceController(IManager manager)
        {
            _manager = manager;
        }

        public IActionResult ProductsIndex()
        {
            var products = _manager.productManager.GetAllProducts();
            return View(products);
        }

        public IActionResult ServicesIndex()
        {
            var services = _manager.serviceManager.GetAllService();
            return View(services);
        }

        [Authorize]
        [HttpGet]
        public IActionResult ProductsAdd()
        {
            return View(new AddProductViewModel());
        }
        [Authorize]
        [HttpPost]
        public IActionResult ProductsAdd(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _manager.productManager.AddProduct(
                new Product()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Image = model.Image,
                    PricePerUnit = model.PricePerUnit
                });
            return RedirectToAction("ProductsIndex");
        }
        [Authorize]
        [HttpGet]
        public IActionResult ServicesAdd()
        {
            return View(new AddServiceViewModel());
        }
        [Authorize]
        [HttpPost]
        public IActionResult ServicesAdd(AddServiceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _manager.serviceManager.AddService(
                new Service()
                {
                    Name = model.Name, 
                    Description = model.Description, 
                    Image = model.Image
                });
            return RedirectToAction("ServicesIndex");
        }

        public IActionResult ViewProduct(int id)
        {
            var product = _manager.productManager.GetProduct(id);
            return View(product);
        }

        public IActionResult ViewService(int id)
        {
            var service = _manager.serviceManager.GetService(id);
            return View(service);
        }
    }
}
