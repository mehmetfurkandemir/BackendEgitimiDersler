using System.Diagnostics;

namespace Project04_MVC.Controllers;

public class MVC01RazorSyntaxContoller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
