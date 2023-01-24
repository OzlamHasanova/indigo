using Microsoft.AspNetCore.Mvc;
using System;

namespace Indigo.Controllers;
    
public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    
}

