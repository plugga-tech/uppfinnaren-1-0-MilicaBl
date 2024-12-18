using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class DatabaseCategoryRepository:ICategoryRepository
{
    private readonly AppDbContext _context;
    public DatabaseCategoryRepository(AppDbContext context)
    {
        _context=context;
    }
    public IEnumerable<Category> GetAllCategories()
    {
        return _context.Categories.ToList();
    }
}
