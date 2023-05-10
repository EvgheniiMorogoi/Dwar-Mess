using FlowerShop.Data.DbModels;
using System.Data.Entity;

namespace FlowerShop.Data
{
     public interface IAppDataBaseContext
     {
        DbSet<FlowerDbModel> Flowers{ get; set; }
        int SaveChanges();
     }
}