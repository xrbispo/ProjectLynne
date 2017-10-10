using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVManager.DataAccessAPI.Models
{
    public class RackServer : PhysicalHost
    {
        [JsonProperty(Order = 11, Required = Required.Always)]
        public Rack Rack { get; set; }
    }
}
