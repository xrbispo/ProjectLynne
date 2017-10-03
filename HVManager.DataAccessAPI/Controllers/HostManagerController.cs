using HVManager.DataAccessAPI.Models;
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

        [HttpPut("{id}")]
        public IActionResult SaveHost([FromRoute] int id, [FromBody] BaseHost host)
        {
            TryValidateModel(host);
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != host.HostID)
            {
                return BadRequest();
            }

            _repository.UpdateHost(host);

            return Ok(_repository.GetHostByID(host.HostID));
        }

        [HttpPost]
        public IActionResult AddHost([FromBody] BaseHost host)
        {
            TryValidateModel(host);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.GetAllHosts();
            
            return Ok();
        }
    }
}