using HVManager.DataAccessAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HVManager.DataAccessAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/ProductManager")]
    public class ProductManagerController : Controller
    {
        // Context 
        private IProductRepository _repository;
        public ProductManagerController(IProductRepository repo)
        {
            _repository = repo;
        }

        // GetAll
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _repository.GetAllProducts();

            return Ok(products);
        }
    }
}