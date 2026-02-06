using Microsoft.EntityFrameworkCore;
using Webshop.Models;
public class GenericRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _set;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _set = context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _set.ToListAsync(); // EF Core generates SQL
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _set.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _set.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _set.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _set.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
