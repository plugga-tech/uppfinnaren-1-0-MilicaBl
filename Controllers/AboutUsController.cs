using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_MilicaBl.Models.About;

public class AboutUsController : Controller
{
    private readonly IAboutUsRepository _aboutUsRepository;

    public AboutUsController(IAboutUsRepository aboutUsRepository)
    {
        _aboutUsRepository = aboutUsRepository;
    }
    public IActionResult Index()
    {
        // Page title
        ViewBag.title = "Om oss";
        var aboutUs = _aboutUsRepository.GetAboutUs();
        return View(aboutUs);
    }
}