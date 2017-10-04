using HVManager.DataAccessAPI.Extensions;
using HVManager.DataAccessAPI.Models;
using HVManager.DataAccessAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/HostManager")]
    [ValidateModel]
    public class HostManagerController : Controller
    {
        // Context 
        private IHostRepository _repository;
        public HostManagerController(IHostRepository repo)
        {
            _repository = repo;
        }


        // GetAll
        [HttpGet]
        public IActionResult GetAllHosts()
        {
            var hosts = _repository.GetAllHosts();

            return Ok(hosts);
        }

        // GetByID
        [HttpGet("GetByID/{id}")]
        public IActionResult GetHostByID([FromRoute] int id)
        {
            var host = _repository.GetHostByID(id);
            
            if(host == null) {
                return NotFound();
            }

            return Ok(host);
        }

        // GetByName
        [HttpGet("GetByName/{hostname}")]
        public IActionResult GetHostByName([FromRoute] string hostname)
        {
            var host = _repository.GetHostByName(hostname);

            if (host == null)
            {
                return NotFound();
            }

            return Ok(host);
        }


        // Create
        [HttpPost]
        public IActionResult AddHost([FromBody] BaseHost host)
        {

            var hostname = _repository.GetHostByName(host.Name);
            if (hostname != null)
            {
                //var errorMessage = ("", host.Name);
                return BadRequest($"The hostname {host.Name.ToUpper()} already exists!");
            }

            _repository.CreateHost(host);
            return Ok();
        }

        // Update
        [HttpPut("{id}")]
        public IActionResult SaveHost([FromRoute] int id, [FromBody] BaseHost host)
        {
            
            if (id != host.HostID)
            {
                return BadRequest();
            }

            _repository.UpdateHost(host);

            return Ok();
        }
    }
}