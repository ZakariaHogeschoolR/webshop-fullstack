using Microsoft.EntityFrameworkCore;
using Webshop.Models;
public class ProductCategoryRepository
{
    private readonly ApplicationDbContext _context;

    public ProductCategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ProductCategory?> GetByIdAsync(int productId, int categoryId)
    {
        return await _context.ProductCategories.Where(pc => pc.ProductId == productId && pc.CategoryId == categoryId).FirstOrDefaultAsync();
    }

}
