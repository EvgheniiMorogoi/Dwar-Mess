using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.Web.Models.Flowers;
using FlowerShop.Web.Services.Interfaces;

namespace FlowerShop.Web.Services
{
     public class FlowerService : IFlowerService
     {
          private readonly IFlowerManager _flowerManager;
          public FlowerService(IFlowerManager flowerManager)
          {
               _flowerManager = flowerManager;
          }
          public FlowerIndexViewModel GetAllFlowers()
          {
               return new FlowerIndexViewModel()
               {
                    Flowers = _flowerManager.GetAllFlowers().Select(x => new FlowerModel()
                    {
                         Name = x.Name,
                         Description = x.Description,
                         Price = x.Price
                    }).ToList(),
               };
          }

          public FlowerDetailViewModel GetFlower(int id)
          {
               var flower = _flowerManager.GetById(id);
               var flowerModel = new FlowerDetailViewModel();
               flowerModel.model.Id = flower.Id;
               flowerModel.model.Name = flower.Name;
               flowerModel.model.Description = flower.Description;
               flowerModel.model.Price = flower.Price;
               return flowerModel;
          }
     }
}