
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public class VirtualHost :BaseHost
    {
        [JsonProperty(Order = 3,Required = Required.Always)]
        [Required]
        [Range(1, 48, ErrorMessage = "CPU must be between 1..48 processors")]
        public int CPU { get; set; }

        [JsonProperty(Order = 11, Required = Required.Always)]
        [Required]
        public Datacenter Datacenter { get; set; }

    }
}
