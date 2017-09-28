
namespace HVManager.DataAccessAPI.Models
{
    public class PhysicalHost :BaseHost
    {
        public int Sockets { get; private set; }

        public int CoresPerSocket { get; private set; }
    }
}
