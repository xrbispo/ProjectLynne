using HVManager.DataAccessAPI.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    [JsonConverter(typeof(HostJsonConverter))]
    public abstract class BaseHost
    {

        [Key]
        [JsonProperty(Order = 0)]
        public int HostID { get; set; }

        [JsonProperty(Order = 1,Required = Required.Always)]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must have between 3 and 15 characters")]
        public string Name { get; set; }

        [JsonProperty(Order = 2, Required = Required.Always)]
        public OS OS { get; set; }

        [JsonProperty(Order = 5, Required = Required.Always)]
        [Range(1, 768, ErrorMessage = "Memory size must be between 1GB and 768GB")]
        public int Memory { get; set; }

        [JsonProperty(Order = 6, Required = Required.Always)]
        public ICollection<Disk> Disks { get; set; }

        [JsonProperty(Order = 7, Required = Required.Always)]
        public ICollection<Network> Networks { get; set; }

        [JsonProperty(Order = 8, Required = Required.Always)]
        public Product Product { get; set; }

    }
}
