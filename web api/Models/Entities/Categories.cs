using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Categories
    {
        [Key]
        public int Categoryid { get; set; }

        public string Category_Name { get; set; }

        public string Description { get; set; }


    }
}
