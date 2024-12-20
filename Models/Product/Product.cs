using System;
using System.ComponentModel;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class Product
{
    public int ProductId { get; set; } //Primary key
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public int CategoryId { get; set; }//Foreign key
    public Category Category { get; set; } = null!;
    public int MaterialId { get; set; }//Foreign key
    public Material Material { get; set; }=null!;
}