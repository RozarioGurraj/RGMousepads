using Microsoft.AspNetCore.Mvc;

namespace RGMousepads.Controllers
{
    public class MousePads : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
