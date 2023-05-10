using FlowerShop.Data;
using FlowerShop.Data.DbModels;
using FlowerShop.Web.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FlowerShop.Web.Controllers
{
     public class AccountController : Controller
     {
          private readonly UserManager<AppUserDbModel> _userManager;
          private readonly SignInManager<AppUserDbModel, string> _signInManager;

          //public AccountController(UserManager<AppUserDbModel> userManager, SignInManager<AppUserDbModel, string> signInManager)
          //{
          //     _userManager = userManager;
          //     _signInManager = signInManager;
          //}
          public AccountController()
          {

          }

          [HttpGet]
          public ActionResult Login()
          {
               return View();
          }

          [HttpPost]
          public ActionResult Login(LoginViewModel model)
          {
               if (!ModelState.IsValid)
               {
                    return View(model);
               }

               using (var db = new AppDataBaseContext())
               {
                    var user = db.Users.FirstOrDefault(u => u.UserName == model.Username);
                    var pHasher = new PasswordHasher();
                    if (user != null && (pHasher.VerifyHashedPassword(user.PasswordHash, model.Password) == PasswordVerificationResult.Success))
                    {
                         return RedirectToAction("Index", "Home");
                    }

                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
               }
          }

          [HttpGet]
          public ActionResult Register()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public async Task<ActionResult> Register(RegisterViewModel model)
          {
               if (!ModelState.IsValid)
               {
                    return View(model);
               }

               var user = new AppUserDbModel
               {
                    UserName = model.Username,
                    Email = model.Email
               };

               var result = await _userManager.CreateAsync(user, model.Password);

               if (result.Succeeded)
               {
                    await _signInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    return RedirectToAction("Index", "Home");
               }

               foreach (var error in result.Errors)
               {
                    ModelState.AddModelError("", error);
               }

               return View(model);
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Logout()
          {
               FormsAuthentication.SignOut();
               return RedirectToAction("Login", "Account");
          }
     }
}