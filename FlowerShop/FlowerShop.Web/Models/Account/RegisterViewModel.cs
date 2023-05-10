using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerShop.Web.Models.Account
{
     public class RegisterViewModel
     {
          [Required]
          [Display(Name = "Full name")]
          public string FullName { get; set; }

          [Required]
          [Display(Name = "Username")]
          public string Username { get; set; }

          [Required]
          [Display(Name = "Email")]
          public string Email { get; set; }

          [Required]
          [Display(Name = "Password")]
          public string Password { get; set; }

          [Required]
          [Display(Name = "Confirm password")]
          public string ConfirmPassword { get; set; }
     }
}