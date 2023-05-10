using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerShop.Web.Models.Account
{
     public class LoginViewModel
     {
          [Required(ErrorMessage = "You need to type the username")]
          [Display(Name = "Username")]
        public string Username { get; set; }

          [Required(ErrorMessage ="You need to type the password")]
          [Display(Name = "Password")]
        public string Password { get; set; }
    }
}