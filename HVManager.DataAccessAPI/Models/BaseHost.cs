using System.ComponentModel.DataAnnotations;

namespace HVManager.DataAccessAPI.Models
{
    public abstract class BaseHost
    {
        [Key]
        public int HostID { get; private set; }

        public string Name { get; private set; }

    }
}
