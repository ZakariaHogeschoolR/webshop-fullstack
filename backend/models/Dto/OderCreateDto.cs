using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class OrderCreateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}