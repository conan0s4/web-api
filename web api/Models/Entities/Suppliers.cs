using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }
        public string Supplier_Name { get; set; }
        public string Address { get; set; }

        public string email { get; set; }
        public string Tax_code { get; set; }
    }
}
