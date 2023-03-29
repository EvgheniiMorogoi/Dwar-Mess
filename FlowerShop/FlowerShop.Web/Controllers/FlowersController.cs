using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Web.Controllers
{
    public class FlowersController : Controller
    {
          private readonly ApplicationDbContext _context;

          public FlowerController(ApplicationDbContext context)
          {
               _context = context;
          }

          public IActionResult Index()
          {
               var products = _context.Flowers.ToList();
               return View(products);
          }
     }
}
/*
  app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "products",
        pattern: "products",
        defaults: new { controller = "Products", action = "Index" });
});
it wouldn't be there next time ,just for save the code not too far from the project
*/
