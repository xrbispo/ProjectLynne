using System.ComponentModel.DataAnnotations.Schema;

namespace HVManager.DataAccessAPI.Models
{
    public class Vlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VlanID { get; set; }

        public string Description { get; set; }

        public string Subnet { get; set; }

    }
}