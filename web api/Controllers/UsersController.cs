using Microsoft.AspNetCore.Mvc;
using webapi.DTO;
using web_api.Data;
using web_api.Models.Entities;




namespace webapi.Controllers


{

    [ApiController]
    [Route("api/Users")]
    public class UsersController : ControllerBase 
    {
        // view and create users
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.User.Select(u => new UsersDTO
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email
            }).ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UsersDTO userDto)
        {
            var user = new Users
            {
                Name = userDto.Name,
                Email = userDto.Email
            };
            _context.User.Add(user);
            _context.SaveChanges();
            userDto.Id = user.Id;
            return CreatedAtAction(nameof(GetUsers), new { id = userDto.Id }, userDto);
        }


    }
}
