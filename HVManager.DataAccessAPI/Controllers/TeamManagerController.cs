using HVManager.DataAccessAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamManager")]
    public class TeamManagerController : Controller
    {
        // Context 
        private ITeamRepository _repository;
        public TeamManagerController(ITeamRepository repo)
        {
            _repository = repo;
        }


        // GetAll
        [HttpGet]
        public IActionResult GetAllTeams()
        {
            var teams = _repository.GetAllTeams();

            return Ok(teams);
        }
    }
}