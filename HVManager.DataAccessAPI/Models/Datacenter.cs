using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Datacenter
    {
        public int DatacenterID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Datacenter name must have between 3 and 20 characters")]
        [Display(Name = "Datacenter Name")]
        public string Name { get; set; }
    }
}