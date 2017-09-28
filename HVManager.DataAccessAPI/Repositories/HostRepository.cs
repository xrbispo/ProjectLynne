using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

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

    }
}
