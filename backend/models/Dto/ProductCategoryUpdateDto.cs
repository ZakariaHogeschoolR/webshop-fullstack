using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class ProductCategoryUpdateDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}