using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public class DatacenterRepository : IDatacenterRepository
    {
        private DataContext _context;
        public DatacenterRepository(DataContext ctx)
        {
            _context = ctx;
        }

        // GetAll
        public IEnumerable<Datacenter> GetAllDatacenters() => _context.Datacenters;
    }
}
