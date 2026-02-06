namespace Webshop.Models
{
    public class Payment
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}