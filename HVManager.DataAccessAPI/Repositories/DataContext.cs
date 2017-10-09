using HVManager.DataAccessAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HVManager.DataAccessAPI.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BaseHost> Hosts { get; set; }

        public DbSet<VirtualHost> VirtualHosts { get; set; }
        public DbSet<PhysicalHost> PhysicalHosts { get; set; }

        public DbSet<OS> OS { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<Vlan> Vlans { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Team> Teams { get; set; }


    }
}
