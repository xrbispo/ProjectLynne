using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HVManager.DataAccessAPI.Repositories;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/OSManager")]
    public class OSManagerController : Controller
    {

        // Context 
        private IOSRepository _repository;
        public OSManagerController(IOSRepository repo)
        {
            _repository = repo;
        }


        // GetAll
        [HttpGet]
        public IActionResult GetAllOS()
        {
            var os = _repository.GetAllOS();

            return Ok(os);
        }
    }
}