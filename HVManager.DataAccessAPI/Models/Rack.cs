using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Rack
    {
        public int RackID { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3)]
        [Display(Name = "RackNumber/FI Domain")]
        public string Number { get; set; }
    }
}