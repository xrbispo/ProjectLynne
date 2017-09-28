
using Newtonsoft.Json;

namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        [JsonProperty(Order = 2)]
        public int Sockets { get; private set; }

        [JsonProperty(Order = 3)]
        public int CoresPerSocket { get; private set; }
    }
}
