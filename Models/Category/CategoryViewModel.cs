using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class CategoryViewModel
{
    public required Category Category { get; set; }
    public required IEnumerable<Product> Products { get; set; }
}
