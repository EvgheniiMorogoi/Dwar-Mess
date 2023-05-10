using FlowerShop.BusinessLogic.Models;
using FlowerShop.Data.DbModels;
using System.Collections.Generic;

namespace FlowerShop.BusinessLogic.Interfaces
{
    public interface IFlowerManager
    {
          List<FlowerDTO> GetAllFlowers();
          FlowerDTO GetById(int id);
          void AddNewFlower(FlowerDTO flower);
          void DeleteById(FlowerDTO flower);
          void Update(FlowerDTO flower);
     }
}