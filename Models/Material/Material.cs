using System;
using System.ComponentModel;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class Material
{
    public required int MaterialId { get; set; }
    public required string Name { get; set; }
    public required string ImageUrl { get; set; }
    public required string Description { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
