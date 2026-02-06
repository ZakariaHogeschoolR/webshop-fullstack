namespace Webshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName  { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}