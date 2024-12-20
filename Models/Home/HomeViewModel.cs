using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class HomeViewModel
{
    public required IEnumerable<Category> Categories { get; set; }
    public required IEnumerable<Material> Materials { get; set; }
}
