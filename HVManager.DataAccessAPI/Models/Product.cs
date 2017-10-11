using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HVManager.DataAccessAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
    }
}
