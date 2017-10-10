
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public abstract class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 3, Required = Required.Always)]
        public int Sockets { get; set; }

        [JsonProperty(Order = 4, Required = Required.Always)]
        public int CoresPerSocket { get; set; }

        [JsonProperty(Order = 12, Required = Required.Always)]
        public HardwareModel HardwareModel { get; set; }

        [JsonProperty(Order = 13, Required = Required.Always)]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Serial/ServiceTag must have between 7 and 20 characters")]
        [Display(Name = "Serial/ServiceTag")]
        public string Serial { get; set; }

        [JsonProperty(Order = 14, Required = Required.Always)]
        public string WWPN1 { get; set; }

        [JsonProperty(Order = 15, Required = Required.Always)]
        public string WWPN2 { get; set; }   
    }
}
