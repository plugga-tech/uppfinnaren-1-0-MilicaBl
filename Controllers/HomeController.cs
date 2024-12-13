using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_MilicaBl.Models;

namespace uppfinnaren_1_0_MilicaBl.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICategoryRepository _categoryRepository;

    public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository)
    {
        _logger = logger;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        ViewBag.title = "The Wood Atelier";
        var categories = _categoryRepository.GetAllCategories();
        return View(categories);
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
