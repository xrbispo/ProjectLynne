using Microsoft.AspNetCore.Mvc;
using HVManager.DataAccessAPI.Repositories;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/DatacenterManager")]
    public class DatacenterManagerController : Controller
    {
        // Context 
        private IDatacenterRepository _repository;
        public DatacenterManagerController(IDatacenterRepository repo)
        {
            _repository = repo;
        }


        // GetAll
        [HttpGet]
        public IActionResult GetAllDatacenters()
        {
            var datacenters = _repository.GetAllDatacenters();

            return Ok(datacenters);
        }
    }
}