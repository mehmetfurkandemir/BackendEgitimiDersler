using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Project03_MVCTemelleri.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult MyPage()
    {
        return View();
    }
}


