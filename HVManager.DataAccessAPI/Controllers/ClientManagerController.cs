using Microsoft.AspNetCore.Mvc;
using HVManager.DataAccessAPI.Repositories;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/ClientManager")]
    public class ClientManagerController : Controller
    {
        // Context 
        private IClientRepository _repository;
        public ClientManagerController(IClientRepository repo)
        {
            _repository = repo;
        }


        // GetAll
        [HttpGet]
        public IActionResult GetAllClients()
        {
            var clients = _repository.GetAllClients();

            return Ok(clients);
        }
    }
}