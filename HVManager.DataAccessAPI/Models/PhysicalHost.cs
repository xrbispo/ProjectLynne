
using Newtonsoft.Json;

namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 3, Required = Required.Always)]
        public int Sockets { get; set; }

        [JsonProperty(Order = 4, Required = Required.Always)]
        public int CoresPerSocket { get; set; }
    }
}
