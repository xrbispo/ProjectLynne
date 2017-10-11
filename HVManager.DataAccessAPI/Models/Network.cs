using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Network
    {
        public int NetworkID { get; set; }

        [Required]
        public Vlan Vlan { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 11)]
        
        [RegularExpression(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])(\/([0-9]|[1-2][0-9]|3[0-2]))$", ErrorMessage = "IP Address must be in this format 192.168.0.10/24")]
        public string IP { get; set; }

        [Required]
        [StringLength(17,MinimumLength = 17)]
        [RegularExpression(@"^([0-9A-Fa-f]{2}:){5}[0-9A-Fa-f]{2}$", ErrorMessage = "MAC Address must be in this format 12:23:34:45:56:67")]
        public string MAC { get; set; }

        public BaseHost Host { get; set; }
    }
}