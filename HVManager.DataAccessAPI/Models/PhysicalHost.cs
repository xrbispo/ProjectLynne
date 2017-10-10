
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 3, Required = Required.Always)]
        public int Sockets { get; set; }

        [JsonProperty(Order = 4, Required = Required.Always)]
        public int CoresPerSocket { get; set; }

        //[JsonProperty(Order = 11, Required = Required.Always)]
        //public Rack Rack { get; set; }

        [JsonProperty(Order = 12, Required = Required.Always)]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Serial/ServiceTag must have between 7 and 20 characters")]
        [Display(Name = "Serial/ServiceTag")]
        public HardwareModel Model { get; set; }
    }
}
