using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class MaterialViewModel
{
    public required IEnumerable<Product> Products { get; set; }
    public required Material Material { get; set; }
}
