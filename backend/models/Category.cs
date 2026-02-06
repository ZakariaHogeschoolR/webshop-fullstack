namespace Webshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public string Slug { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime CreatedAt { get; set; }
        
    }
}