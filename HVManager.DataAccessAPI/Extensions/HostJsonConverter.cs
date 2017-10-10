using System;
using HVManager.DataAccessAPI.Models;
using Newtonsoft.Json.Linq;

namespace HVManager.DataAccessAPI.Extensions
{
    public class HostJsonConverter : JsonCreationConverter<BaseHost>
    {
        private bool FieldExists(string fieldName, JObject jObject)
        {
            var jString = jObject.ToString().ToLower().Replace("\"",string.Empty).Replace(Environment.NewLine,string.Empty);
            return jString.Contains(fieldName) != false;
        }

        protected override BaseHost Create(Type objectType, JObject jObject)
        {
            if (FieldExists("cpu:", jObject))
            {
                return new VirtualHost();
            }
            else 
            {
                return new RackServer();
            }
            
        }
    }
}
