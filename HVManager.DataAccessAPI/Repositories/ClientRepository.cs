using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DataContext _context;
        public ClientRepository(DataContext ctx)
        {
            _context = ctx;
        }

        // GetAll
        public IEnumerable<Client> GetAllClients() => _context.Clients;
    }
}
