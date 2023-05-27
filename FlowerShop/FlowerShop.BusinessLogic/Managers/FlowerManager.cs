using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.BusinessLogic.Models;
using FlowerShop.Data.DbModels;
using FlowerShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.BusinessLogic.Managers
{
     public class FlowerManager : IFlowerManager
     {
          private readonly IFlowerRepository _flowerRepository;
          public FlowerManager(IFlowerRepository flowerRepository)
          {
               _flowerRepository = flowerRepository;
          }

          public void AddNewFlower(FlowerDTO flower)
          {
               _flowerRepository.AddNewFlower(
                    new FlowerDbModel()
                    {
                         Name = flower.Name,
                         Description = flower.Description,
                         Price = flower.Price
                    });
          }

          public void DeleteById(FlowerDTO flower)
          {
               throw new NotImplementedException();
               //_flowerRepository.DeleteById()
          }

          public List<FlowerDTO> GetAllFlowers()
          {
               return _flowerRepository.GetAllFlowers().Select(x => new FlowerDTO() {Id = x.Id, Name = x.Name, Description = x.Description, Price = x.Price }).ToList();
          }

          public FlowerDTO GetById(int id)
          {
               var flower = _flowerRepository.GetById(id);
               var FlowerDto = new FlowerDTO()
               {
                    Id = flower.Id,
                    Name = flower.Name,
                    Description = flower.Description,
                    Price = flower.Price
               };
               return FlowerDto;
          }

          public void Update(FlowerDTO flower)
          {
               _flowerRepository.Update(new FlowerDbModel() { Name = flower.Name, Description = flower.Description, Price = flower.Price });
          }
     }
}
