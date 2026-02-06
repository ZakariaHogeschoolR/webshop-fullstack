using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class ShipmentCreateDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public DateTime ShippedAt { get; set; }
    }
}