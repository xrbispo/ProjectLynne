using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class Network
    {
        public int NetworkID { get; set; }

        [Required]
        public Vlan Vlan { get; set; }

        [Required]
        public string IP { get; set; }

        [Required]
        public string MAC { get; set; }

        public BaseHost Host { get; set; }
    }
}