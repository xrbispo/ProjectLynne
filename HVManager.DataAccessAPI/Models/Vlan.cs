using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVManager.DataAccessAPI.Models
{
    public class Vlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VlanID { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 10, ErrorMessage = "Subnet must have between 10 and 18 characters including separators and mask Ex:[192.168.0.10/24]")]
        [Display(Name = "Subnet IP")]
        public string Subnet { get; set; }

    }
}