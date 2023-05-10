using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.DbModels
{
     public class FlowerDbModel
     {
          [Key]
          public int Id { get; set; }

          [Required(AllowEmptyStrings = false)]
          [StringLength(50)]
          [DisplayName("Nume floare")]
          public string Name { get; set; }

          [Required(AllowEmptyStrings = false)]
          [StringLength(256), MinLength(1)]
          [DisplayName("Descriere floare")]
          public string Description { get; set; }

          [Required]
          [DisplayName("Pret floare")]
          public decimal Price { get; set; }

          [Required]
          [DefaultValue(false)]
          public bool HasImage { get; set; }

          [DefaultValue(null)]
          public string ImageUrl { get; set; }
     }
}
