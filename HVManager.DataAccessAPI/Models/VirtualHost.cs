
using Newtonsoft.Json;

namespace HVManager.DataAccessAPI.Models
{
    public class VirtualHost :BaseHost
    {
        [JsonProperty(Order = 2)]
        public int CPU { get; private set; }

    }
}
