using FlowerShop.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Web.Controllers
{
     public class FlowersController : Controller
     {
          private readonly IFlowerService _flowerService;

          //[Autowired]
          public FlowersController(IFlowerService flowerService)
          {
               _flowerService = flowerService;
          }

          // GET: Flowers
          [Authorize]
          public ActionResult Index()
          {
               return View(_flowerService.GetAllFlowers());
          }

          // GET: Flowers/Details/5
          public ActionResult Details(int id)
          {
               var viewModel = _flowerService.GetFlower(id);
               return View(viewModel);
          }

          // GET: Flowers/Create
          public ActionResult Create()
          {
               return View();
          }

          // POST: Flowers/Create
          [HttpPost]
          public ActionResult Create(FormCollection collection)
          {
               try
               {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
               }
               catch
               {
                    return View();
               }
          }

          // GET: Flowers/Edit/5
          public ActionResult Edit(int id)
          {
               return View();
          }

          // POST: Flowers/Edit/5
          [HttpPost]
          public ActionResult Edit(int id, FormCollection collection)
          {
               try
               {
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
               }
               catch
               {
                    return View();
               }
          }

          // GET: Flowers/Delete/5
          public ActionResult Delete(int id)
          {
               return View();
          }

          // POST: Flowers/Delete/5
          [HttpPost]
          public ActionResult Delete(int id, FormCollection collection)
          {
               try
               {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
               }
               catch
               {
                    return View();
               }
          }
     }
}
