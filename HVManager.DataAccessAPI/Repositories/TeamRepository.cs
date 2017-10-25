using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public class TeamRepository :ITeamRepository
    {
        private DataContext _context;
        public TeamRepository(DataContext ctx)
        {
            _context = ctx;
        }

        // GetAll
        public IEnumerable<Team> GetAllTeams() => _context.Teams;
    }
}
