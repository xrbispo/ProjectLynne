using System.Collections.Generic;
using HVManager.DataAccessAPI.Models;

namespace HVManager.DataAccessAPI.Repositories
{
    public class OSRepository : IOSRepository
    {
        private DataContext _context;
        public OSRepository(DataContext ctx)
        {
            _context = ctx;
        }

        // GetAll
        public IEnumerable<OS> GetAllOS() => _context.OS;
    }
}


