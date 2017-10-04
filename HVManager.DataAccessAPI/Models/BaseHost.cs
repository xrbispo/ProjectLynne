﻿using HVManager.DataAccessAPI.Extensions;
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
        public int HostID { get; set; }

        [JsonProperty(Order = 1,Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(Order = 2, Required = Required.Always)]
        public OS OS { get; set; }

        [JsonProperty(Order = 5, Required = Required.Always)]
        public int Memory { get; set; }

        [JsonProperty(Order = 6, Required = Required.Always)]
        public ICollection<Disk> Disks { get; set; }
    }
}
