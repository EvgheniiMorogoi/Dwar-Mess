using FlowerShop.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Repositories.Interfaces
{
     public interface IFlowerRepository
     {
          List<FlowerDbModel> GetAllFlowers();
          FlowerDbModel GetById(int id);
          void AddNewFlower(FlowerDbModel flower);
          void DeleteById(int id);
          void Update(FlowerDbModel flower);

     }
}
