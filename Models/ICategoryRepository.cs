using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategories();
}
