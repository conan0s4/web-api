using Microsoft.AspNetCore.Mvc;
using webapi.DTO;
using web_api.Data;
using web_api.Models.Entities;
using webapi.Models.Entities;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Product.Select(c => new ProductsDto
            {
                ProductId = c.ProductId,
                ProductName = c.ProductName,
                Quantity = c.Quantity,
                CategoryId = c.CategoryId,
                SupplierId = c.SupplierId,
                Date_Arrived = c.Date_Arrived,
                Date_Expired = c.Date_Expired,
                Batch_number = c.Batch_number
            }).ToList();

            return Ok(products);
        }





    }
}
