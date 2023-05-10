using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using FlowerShop.BusinessLogic.Managers;
using FlowerShop.Data.DbModels;
using FlowerShop.Data;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FlowerShop.Web
{
     public static class IdentityConfig
     {
          public static void ConfigureIdentity(UserManager<AppUserDbModel> userManager, RoleManager<IdentityRole> roleManager, IAppBuilder app)
          {
               app.CreatePerOwinContext(() => new AppDataBaseContext());

               // Configurare UserManager
               userManager.UserValidator = new UserValidator<AppUserDbModel>(userManager)
               {
                    AllowOnlyAlphanumericUserNames = false,
                    RequireUniqueEmail = true
               };

               // Configurare PasswordValidator
               userManager.PasswordValidator = new PasswordValidator
               {
                    RequiredLength = 6,
                    RequireNonLetterOrDigit = false,
                    RequireDigit = true,
                    RequireLowercase = true,
                    RequireUppercase = true,
               };

               // Configurare Lockout
               userManager.UserLockoutEnabledByDefault = true;
               userManager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
               userManager.MaxFailedAccessAttemptsBeforeLockout = 5;

               // Configurare SignInManager
               var authenticationOptions = new CookieAuthenticationOptions
               {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Account/Login"),
                    Provider = new CookieAuthenticationProvider
                    {
                         OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<UserManager<AppUserDbModel>, AppUserDbModel, string>(
                         validateInterval: TimeSpan.FromMinutes(30),
                         regenerateIdentityCallback: (manager, user) => user.GenerateUserIdentityAsync(manager),
                         getUserIdCallback: (id) => id.GetUserId())
                    }
               };
               app.UseCookieAuthentication(authenticationOptions);
          }
     }
}
