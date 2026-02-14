using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using web_api.Models.Entities;
using webapi.Models.Entities;

namespace web_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Users> User { get; set; }

        public DbSet<Categories> Category { get; set; }

        public DbSet<Products> Product { get; set; }

        public DbSet<Suppliers> Supplier { get; set; }









    }
}
