using System;
using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using uppfinnaren_1_0_MilicaBl.Models;

namespace uppfinnaren_1_0_MilicaBl.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {   
        // Page title
        ViewBag.title = "Kontakt";
        
        var contactInfo = new ContactInfo
        {
            Email = "thewoodatalier@info.com",
            Address = "Uppfinnarvägen 1, 12345 Göteborg"
        };
        return View(contactInfo);
    }
}
