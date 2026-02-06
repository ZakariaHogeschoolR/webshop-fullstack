using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class ProductCategoryCreateDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}