using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_MilicaBl.Models;

namespace uppfinnaren_1_0_MilicaBl.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IActionResult Index()
    {
        ViewBag.title = "Produkter";
        return View(_productRepository.AllProducts);
    }
    public IActionResult Info(int id)
    {
        var product = _productRepository.GetProductById(id);
        ViewBag.title = "Produktdetaljer -" + product?.Name;
        return View(product);
    }
    public IActionResult ByCategory(int id)
    {
        var products = _productRepository.GetProductsByCategoryId(id);
        var category = products.First().Category;
        ViewBag.title = category.Name;
        ViewBag.Category = category;

        return View(products);
    }
}
