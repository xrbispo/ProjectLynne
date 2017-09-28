using HVManager.DataAccessAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/HostManager")]
    public class HostManagerController : Controller
    {
        private IHostRepository _repository;

        public HostManagerController(IHostRepository repo)
        {
            _repository = repo;
        }


        [HttpGet]
        public IActionResult GetAllHosts()
        {
            var hosts = _repository.GetAllHosts();

            return Ok(hosts);
        }


        [HttpGet("{id}")]
        public IActionResult GetHostByID(int id)
        {
            var host = _repository.GetHostByID(id);
            
            if(host == null) {
                return NotFound();
            }

            return Ok(host);
        }
    }
}