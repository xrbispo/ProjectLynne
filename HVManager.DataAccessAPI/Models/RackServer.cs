using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVManager.DataAccessAPI.Models
{
    public class RackServer : PhysicalHost
    {
        public Rack Rack { get; set; }
    }
}
