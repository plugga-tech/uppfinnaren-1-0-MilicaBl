using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class Category
{
    public required int CategoryId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string AdditionalDescription { get; set; } = String.Empty;
    public required string ImageUrl { get; set; }
    public required bool IsRowReversed { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
