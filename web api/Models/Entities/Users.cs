namespace web_api.Models.Entities
{
    public class Users 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }

    }
}
