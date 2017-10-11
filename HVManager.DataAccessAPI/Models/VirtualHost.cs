
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class VirtualHost :BaseHost
    {
        [JsonProperty(Order = 3,Required = Required.Always)]
        [Required]
        public int CPU { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        [Required]
        public Datacenter Datacenter { get; set; }

    }
}
