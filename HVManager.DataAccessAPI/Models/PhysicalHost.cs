
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 3, Required = Required.Always)]
        [Required]
        [Range(1, 4, ErrorMessage = "Sockets must be between 1 and 4")]
        public int Sockets { get; set; }

        [JsonProperty(Order = 4, Required = Required.Always)]
        [Required]
        [Range(2, 28, ErrorMessage = "Cores must be between 2 and 28 per socket")]
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
