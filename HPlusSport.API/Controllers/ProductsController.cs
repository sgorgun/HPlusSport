using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated(); // Create the database if it doesn't exist. This is a temporary solution for seeded data.
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            return Ok(_context.Products.ToArray());
        }
    }
}
