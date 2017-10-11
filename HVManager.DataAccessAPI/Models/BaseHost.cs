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
        [Required]
        public int HostID { get; set; }

        [JsonProperty(Order = 1,Required = Required.Always)]
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must have between 3 and 15 characters")]
        public string Name { get; set; }

        [JsonProperty(Order = 2, Required = Required.Always)]
        [Required]
        public OS OS { get; set; }

        [JsonProperty(Order = 5, Required = Required.Always)]
        [Required]
        [Display(Name = "Memory(GB)")]
        public int Memory { get; set; }

        [JsonProperty(Order = 6, Required = Required.Always)]
        [Required]
        public ICollection<Disk> Disks { get; set; }

        [JsonProperty(Order = 7, Required = Required.Always)]
        [Required]
        public ICollection<Network> Networks { get; set; }

        [JsonProperty(Order = 8, Required = Required.Always)]
        [Required]
        public Product Product { get; set; }

        [JsonProperty(Order = 9, Required = Required.Always)]
        [Required]
        public Client Client { get; set; }

        [JsonProperty(Order = 10, Required = Required.Always)]
        [Required]
        public Team Team { get; set; }

    }
}
