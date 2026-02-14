using Microsoft.AspNetCore.Mvc;
using webapi.DTO;
using web_api.Data;
using web_api.Models.Entities;
using webapi.Models.Entities;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/Suppliers")]
    public class SuppliersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuppliersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSuppliers()
        {
            var Suppliers = _context.Supplier.Select(c => new SuppliersDto
            {
                SupplierId = c.SupplierId,
                Supplier_Name = c.Supplier_Name,
                Address = c.Address,
                email = c.email,
                Tax_code = c.Tax_code

            }).ToList();
     

            return Ok(Suppliers);
        }
    }
}
