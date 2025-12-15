using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}