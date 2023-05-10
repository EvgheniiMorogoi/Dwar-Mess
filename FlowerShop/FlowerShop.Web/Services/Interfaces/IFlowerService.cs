using FlowerShop.Web.Models.Flowers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Web.Services.Interfaces
{
     public interface IFlowerService
     {
          FlowerIndexViewModel GetAllFlowers();
     }
}
