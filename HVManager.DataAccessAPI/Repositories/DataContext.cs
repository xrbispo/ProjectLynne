﻿using HVManager.DataAccessAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HVManager.DataAccessAPI.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BaseHost> Hosts { get; set; }

        public DbSet<VirtualHost> VirtualHosts { get; set; }
        public DbSet<PhysicalHost> PhysicalHosts { get; set; }
    }
}