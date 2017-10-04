using HVManager.DataAccessAPI.Extensions;
using Newtonsoft.Json;
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
        public string Name { get; set; }
    }
}
