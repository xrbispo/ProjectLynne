
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
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Serial/ServiceTag must have between 7 and 20 characters")]
        [Display(Name = "Serial/ServiceTag")]
        public string Serial { get; set; }

        [JsonProperty(Order = 14, Required = Required.Always)]
        [Required]
        public string WWPN1 { get; set; }

        [JsonProperty(Order = 15, Required = Required.Always)]
        [Required]
        public string WWPN2 { get; set; }   
    }
}
