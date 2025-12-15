using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}