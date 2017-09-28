using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public abstract class BaseHost
    {
        [Key]
        [JsonProperty(Order = 0)]
        public int HostID { get; private set; }

        [JsonProperty(Order = 1)]
        public string Name { get; private set; }

    }
}
