using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVManager.DataAccessAPI.Models
{
    public class Vlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VlanID { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 10, ErrorMessage = "Subnet must have between 10 and 18 characters including separators and mask Ex:[192.168.0.10/24]")]
        [RegularExpression(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])(\/([0-9]|[1-2][0-9]|3[0-2]))$", ErrorMessage = "Subnet IP Address must be in this format 192.168.0.0/24")]
        [Display(Name = "Subnet IP")]
        public string Subnet { get; set; }

    }
}