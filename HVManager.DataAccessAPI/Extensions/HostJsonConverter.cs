using System;
using HVManager.DataAccessAPI.Models;
using Newtonsoft.Json.Linq;

namespace HVManager.DataAccessAPI.Extensions
{
    public class HostJsonConverter : JsonCreationConverter<BaseHost>
    {
        private bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }

        protected override BaseHost Create(Type objectType, JObject jObject)
        {
            if (FieldExists("CPU", jObject))
            {
                return new VirtualHost();
            }
            else
            {
                return new PhysicalHost();
            }
        }
    }
    }
}
