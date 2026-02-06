using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class CartUpdateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}