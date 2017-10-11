
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 3, Required = Required.Always)]
        [Required]
        public int Sockets { get; set; }

        [JsonProperty(Order = 4, Required = Required.Always)]
        [Required]
        public int CoresPerSocket { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        [Required]
        public Rack Rack { get; set; }

        [JsonProperty(Order = 12, Required = Required.Always)]
        [Required]
        public HardwareModel HardwareModel { get; set; }

        [JsonProperty(Order = 13, Required = Required.Always)]
        [Required]
        [StringLength(20, MinimumLength = 7)]
        [Display(Name = "Serial/ServiceTag")]
        public string Serial { get; set; }

        [JsonProperty(Order = 14, Required = Required.Always)]
        [Required]
        [RegularExpression(@"^([0-9A-Fa-f]{2}:){7}[0-9A-Fa-f]{2}$", ErrorMessage = "WWPN Address must be in this format 10:00:00:00:c9:2e:e8:90")]
        public string WWPN1 { get; set; }

        [JsonProperty(Order = 15, Required = Required.Always)]
        [Required]
        [RegularExpression(@"^([0-9A-Fa-f]{2}:){7}[0-9A-Fa-f]{2}$", ErrorMessage = "WWPN Address must be in this format 10:00:00:00:c9:2e:e8:90")]
        public string WWPN2 { get; set; }   
    }
}
