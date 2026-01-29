using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace webapi.DTO
{
    public class CreateUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
