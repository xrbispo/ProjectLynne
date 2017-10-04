using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVManager.DataAccessAPI.Models
{
    public class Disk
    {
        public int DiskID { get; set; }
        public int Size { get; set; }

        public BaseHost Host { get; set; }
    }
}
