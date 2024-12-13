using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class Category
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string AdditionalDescription { get; set; }
    public string ImageUrl { get; set; }
    public string Link { get; set; }
    public bool IsRowReversed { get; set; }
}
