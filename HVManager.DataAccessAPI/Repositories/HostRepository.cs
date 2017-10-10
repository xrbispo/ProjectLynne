using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HVManager.DataAccessAPI.Repositories
{
    public class HostRepository :IHostRepository
    {
        private DataContext _context;
        public HostRepository(DataContext ctx)
        {
            _context = ctx;
        }


        // GetAll
        public IEnumerable<BaseHost> GetAllHosts() => _context.Hosts
                                                            .Include(r => r.OS)
                                                            .Include(r => r.Disks)
                                                            .Include(r => r.Networks).ThenInclude(r => r.Vlan)
                                                            .Include(r => r.Product)
                                                            .Include(r => r.Client)
                                                            .Include(r => r.Team)
                                                            .Include((PhysicalHost r) => r.HardwareModel);
                                                            
                                                            

        // GetByID
        public BaseHost GetHostByID(int id) => GetAllHosts().SingleOrDefault(r => r.HostID == id);


        // GetByName
        public BaseHost GetHostByName(string name) => GetAllHosts().SingleOrDefault(r => r.Name == name);
        
        // Create
        public void CreateHost(BaseHost host)
        {
            _context.Entry(host).State = EntityState.Added;
            _context.SaveChanges();
        }

        // Update
        public void UpdateHost(BaseHost host)
        {
            _context.Entry(host).State = EntityState.Modified;
            _context.SaveChanges();
        }


    }
}
