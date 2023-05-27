using System.Web.Mvc;
using FlowerShop.BusinessLogic.Interfaces;
using FlowerShop.BusinessLogic.Managers;
using FlowerShop.Data;
using FlowerShop.Data.DbModels;
using FlowerShop.Data.Repositories;
using FlowerShop.Data.Repositories.Interfaces;
using FlowerShop.Web.Services;
using FlowerShop.Web.Services.Interfaces;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace FlowerShop.Web
{
     public static class Bootstrapper
     {
          public static void Initialise()
          {
               var container = BuildUnityContainer();

               DependencyResolver.SetResolver(new UnityDependencyResolver(container));
          }

          private static IUnityContainer BuildUnityContainer()
          {
               var container = new UnityContainer();

               container.RegisterType<IFlowerService, FlowerService>();
               container.RegisterType<IFlowerManager, FlowerManager>();
               container.RegisterType<IFlowerRepository, FlowerRepository>();
               container.RegisterType<IAppDataBaseContext, AppDataBaseContext>();
               //container.//<SignInManager<AppUserDbModel, string>>();
               return container;
          }
     }
}