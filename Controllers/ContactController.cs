using System;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_MilicaBl.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewBag.title = "Kontakt";
        return View();
    }
}
