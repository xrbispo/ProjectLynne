
using Newtonsoft.Json;

namespace HVManager.DataAccessAPI.Models
{
    public class VirtualHost :BaseHost
    {
        [JsonProperty(Order = 2,Required = Required.Always)]
        public int CPU { get; set; }

    }
}
