using Microsoft.AspNetCore.Mvc;
using webapi.DTO;
using web_api.Data;
using web_api.Models.Entities;
using webapi.Models.Entities;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/Categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _context.Category.Select(c => new CategoriesDto
            {
                Categoryid = c.Categoryid,
                Category_Name = c.Category_Name,
                Description = c.Description
            }).ToList();

            return Ok(categories);
        }
    }
}
