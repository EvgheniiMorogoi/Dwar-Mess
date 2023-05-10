using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.DbModels
{
     public class AppUserDbModel : IdentityUser, IUser<string>
     {
          public string Id { get; set; }
          public string UserName { get; set; }
          public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUserDbModel> manager)
          {
               var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
               userIdentity.AddClaim(new Claim(ClaimTypes.Name, this.UserName));
               userIdentity.AddClaim(new Claim(ClaimTypes.Role, "User")); // adauga claim-ul pentru rolul utilizatorului
               return userIdentity;
          }
     }
}
