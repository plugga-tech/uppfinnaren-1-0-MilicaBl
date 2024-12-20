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
        var category = products.First().Category;//Get category of first product
        ViewBag.title = category.Name;
        var viewModel = new CategoryViewModel
        {
            Category = category,
            Products = products
        };

        return View(viewModel);
    }
    public IActionResult ByMaterial(int id)
    {
        var products = _productRepository.GetProductsByMaterial(id);
        var material = products.First().Material;//Get material of first product
        ViewBag.title = material.Name + " material produkter";
        var viewModel = new MaterialViewModel
        {
            Material = material,
            Products = products
        };

        return View(viewModel);
    }
}
