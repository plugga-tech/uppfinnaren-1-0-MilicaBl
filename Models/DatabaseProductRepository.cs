using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class DatabaseProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public DatabaseProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Product> AllProducts
    {
        get
        {
            return _context.Products;
        }
    }

    public IEnumerable<Product> GetProductByCategory(string productCategory)
    {
        return _context.Products.Where(p => p.Category.Equals(productCategory, StringComparison.OrdinalIgnoreCase));
    }

    public Product? GetProductById(int productId)
    {
        return _context.Products.FirstOrDefault(p => p.ProductId == productId);
    }
}
