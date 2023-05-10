using FlowerShop.Data.DbModels;
using FlowerShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Repositories
{
     public class FlowerRepository : IFlowerRepository
     {
          private readonly IAppDataBaseContext _appDataBaseContext;

          public FlowerRepository(IAppDataBaseContext appDataBaseContext)
          {
               _appDataBaseContext = appDataBaseContext;
          }

          public void AddNewFlower(FlowerDbModel flower)
          {
               _appDataBaseContext.Flowers.Add(flower);
               _appDataBaseContext.SaveChanges();
          }

          public void DeleteById(int id)
          {
               _appDataBaseContext.Flowers.Remove(GetById(id));
               _appDataBaseContext.SaveChanges();
          }

          public List<FlowerDbModel> GetAllFlowers()
          {
               var flowers = _appDataBaseContext.Flowers.ToList();
               return flowers;
          }

          public FlowerDbModel GetById(int id)
          {
               var flower = _appDataBaseContext.Flowers.FirstOrDefault(x => x.Id == id);
               return flower;
          }

          public void Update(FlowerDbModel flower)
          {
               var result = _appDataBaseContext.Flowers.SingleOrDefault(b => b.Id == flower.Id);
               if (result != null)
               {
                    result.Name = flower.Name;
                    result.Description = flower.Description;
                    result.Price = flower.Price;
                    result.HasImage = flower.HasImage;
                    if (result.HasImage)
                    {
                         result.ImageUrl = flower.ImageUrl;
                    }
                    _appDataBaseContext.SaveChanges();
               }
               //.Net Core version
               //_appDataBaseContext.Flowers.Update(flower);
               //_appDataBaseContext.SaveChanges();
          }
     }
}
