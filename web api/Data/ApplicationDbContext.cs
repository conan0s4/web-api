using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using web_api.Models.Entities;

namespace web_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Users> User { get; set; }



    }
}
