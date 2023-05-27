using FlowerShop.Data.DbModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data
{
     //public class AppDataBaseContext : IdentityDbContext<AppUserDbModel>, IAppDataBaseContext
     //{
     //     public AppDataBaseContext():base("name=FlowerShop")
     //     {
     //     }

     //     public DbSet<FlowerDbModel> Flowers { get; set; }
     //     protected override void OnModelCreating(DbModelBuilder modelBuilder)
     //     {
     //          base.OnModelCreating(modelBuilder);
     //     }
     //}

     public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
     {
          public ApplicationDbContext()
              : base("name=FlowerShop", throwIfV1Schema: false)
          {
          }
          public DbSet<FlowerDbModel> Flowers { get; set; }

          public static ApplicationDbContext Create()
          {
               return new ApplicationDbContext();
          }
     }
}
