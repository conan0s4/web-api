namespace webapi.DTO
{
    public class ProductsDto
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }

        public int CategoryId { get; set; }

        public int SupplierId { get; set; }

        public int Date_Arrived { get; set; }

        public int Date_Expired { get; set; }

        public int Batch_number { get; set; }
    }
}
