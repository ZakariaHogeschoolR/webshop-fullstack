using System.Diagnostics.Tracing;
using System.Net;
namespace Webshop.Models
{
    public class Order
    {
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}