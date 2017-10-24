using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context;
        public ProductRepository(DataContext ctx)
        {
            _context = ctx;
        }

        // GetAll
        public IEnumerable<Product> GetAllProducts() => _context.Products;
    }
}
