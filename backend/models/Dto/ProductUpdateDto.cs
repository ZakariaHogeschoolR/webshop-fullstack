using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class ProductUpdateDto
    {
        public string ProductName  { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}