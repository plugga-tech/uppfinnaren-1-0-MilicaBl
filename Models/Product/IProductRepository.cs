using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public interface IProductRepository
{
    IEnumerable<Product> AllProducts { get; }
    Product? GetProductById(int productId);
    IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    IEnumerable<Product> GetProductsByMaterial(int materialId);
}
