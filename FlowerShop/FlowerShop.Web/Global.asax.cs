using FlowerShop.Web.Services;
using FlowerShop.Web.Services.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using FlowerShop.Data;
using FlowerShop.BusinessLogic.Managers;
using FlowerShop.Data.DbModels;
using Microsoft.Owin.Builder;

//[assembly: OwinStartup(typeof(FlowerShop.Web.MvcApplication))]
namespace FlowerShop.Web
{
     public class MvcApplication : System.Web.HttpApplication
     {
          protected void Application_Start()
          {
               AreaRegistration.RegisterAllAreas();
               FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
               RouteConfig.RegisterRoutes(RouteTable.Routes);
               BundleConfig.RegisterBundles(BundleTable.Bundles);
               Bootstrapper.Initialise();

               IAppBuilder app = new AppBuilder();
               AppDataBaseContext context = new AppDataBaseContext();
               UserManager<AppUserDbModel> userManager = new UserManager<AppUserDbModel>(new UserStore<AppUserDbModel>(context));
               RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
               IdentityConfig.ConfigureIdentity(userManager, roleManager, app);
          }
          public void Configuration(IAppBuilder app)
          {
               app.CreatePerOwinContext(() => new AppDataBaseContext());
               app.CreatePerOwinContext<UserManager<AppUserDbModel>>(
                   (options, context) =>
                       new UserManager<AppUserDbModel>(
                           new UserStore<AppUserDbModel>(context.Get<AppDataBaseContext>())));

               app.CreatePerOwinContext<RoleManager<IdentityRole>>(
                   (options, context) =>
                       new RoleManager<IdentityRole>(
                           new RoleStore<IdentityRole>(context.Get<AppDataBaseContext>())));

               app.UseCookieAuthentication(new CookieAuthenticationOptions
               {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Account/Login"),
                    Provider = new CookieAuthenticationProvider
                    {
                         OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<UserManager<AppUserDbModel, string>, AppUserDbModel, string>
                         (
                              validateInterval: TimeSpan.FromMinutes(30),
                              regenerateIdentityCallback: (manager, user) => manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie),
                              getUserIdCallback: (id) => id.GetUserId<string>()
                         )
                    }
               });
          }
     }
}
