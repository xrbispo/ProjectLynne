using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Rack
    {
        public int RackID { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Rack number/FI Domain must constain between 3 and 15 characters")]
        [Display(Name = "RackNumber/FI Domain")]
        public string Number { get; set; }
    }
}