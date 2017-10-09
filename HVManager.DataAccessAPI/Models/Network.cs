namespace HVManager.DataAccessAPI.Models
{
    public class Network
    {
        public int NetworkID { get; set; }

        public Vlan Vlan { get; set; }

        public string IP { get; set; }
        public string MAC { get; set; }

        public BaseHost Host { get; set; }
    }
}