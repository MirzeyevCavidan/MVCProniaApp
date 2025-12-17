using Microsoft.AspNetCore.Mvc;
using MVCProniaApp.Models;
using MVCProniaApp.ViewModels;

namespace MVCProniaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>()
            {
                new Slide
                {
                    Id = 1,
                    Title = "Title 1",
                    Discount = 20,
                    Description = "50 qep doner ayran",
                    Order = 3,
                    Image = "1-1-270x300.jpg"
                },
                new Slide
                {
                    Id = 2,
                    Title = "Title 2",
                    Discount = 20,
                    Description = "ustu moyka alti cayxana",
                    Order = 1,
                    Image = "1-11-270x300.jpg"
                },
                new Slide
                {
                    Id = 3,
                    Title = "Title 3",
                    Discount = 20,
                    Description = "50 qep doner ayran",
                    Order = 2,
                    Image = "1-2-524x617.png"
                }
            };
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Name 1",
                    Price = 60,
                    Image = "1-1-270x300.jpg",
                    Order = 3
                },
                new Product
                {
                    Id = 2,
                    Name = "Name 2",
                    Price = 80,
                    Image = "1-11-270x300.jpg",
                    Order = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Name 3",
                    Price = 100,
                    Image = "1-2-524x617.png",
                    Order = 1
                }
            };
            List<Blog> blogs = new List<Blog>
            {
                new Blog
                {
                    Id = 1,
                    Title = "Title 1",
                    Description = "50 qep doner ayran",
                    Author = "Cavidan",
                    Date = new DateTime(2024, 02, 12),
                    Image = "1-2-310x220.jpg"
                },
                new Blog
                {
                    Id = 2,
                    Title = "Title 2",
                    Description = "50 qep doner ayran",
                    Author = "Nihad",
                    Date = new DateTime(2024, 02, 20),
                    Image = "1-3-310x220.jpg"
                },
                new Blog
                {
                    Id = 3,
                    Title = "Title 3",
                    Description = "ustu moyka alti cayxana",
                    Author = "Omer",
                    Date = new DateTime(2025, 05, 20),
                    Image = "1-1-310x220.jpg"
                }
            };
            HomeVM homeVM = new HomeVM()
            {
                Slides = slides,
                Products = products,
                Blogs = blogs
            };
            return View(homeVM);
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}