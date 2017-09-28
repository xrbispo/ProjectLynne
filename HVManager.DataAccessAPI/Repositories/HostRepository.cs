using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace HVManager.DataAccessAPI.Repositories
{
    public class HostRepository :IHostRepository
    {
        private DataContext _context;
        public HostRepository(DataContext ctx)
        {
            _context = ctx;
        }


        public IEnumerable<BaseHost> GetAllHosts() => _context.Hosts;

        public BaseHost GetHostByID(int id) => _context.Hosts.SingleOrDefault(r => r.HostID == id);
  
    }
}
