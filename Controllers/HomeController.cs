using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_MilicaBl.Models;

namespace uppfinnaren_1_0_MilicaBl.Controllers;

public class HomeController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMaterialRepository _materialRepository;

    public HomeController(ICategoryRepository categoryRepository, IMaterialRepository materialRepository)
    {
        _categoryRepository = categoryRepository;
        _materialRepository = materialRepository;
    }

    public IActionResult Index()
    {
        ViewBag.title = "The Wood Atelier";

        var categories = _categoryRepository.GetAllCategories();
        var materials = _materialRepository.GetAllMaterials();

        var viewModel = new HomeViewModel
        {
            Categories = categories,
            Materials = materials
        };
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
