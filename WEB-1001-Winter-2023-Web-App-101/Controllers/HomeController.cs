using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_1001_Winter_2023_Web_App_101.Models;

namespace WEB_1001_Winter_2023_Web_App_101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // ViewData["AuthorName"] = "Test Author";

            var post = new BlogPost() { PublishDate = DateTime.Now.AddDays(-10), Author = new Author() { FullName = "Brent Ritchie", Email = "brent.ritchie@cambriancollege.ca", Photo = new Uri("https://images.unsplash.com/flagged/photo-1570612861542-284f4c12e75f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8cGVyc29ufGVufDB8fDB8fA%3D%3D&w=1000&q=80") }, Title = "My First Post", Description = "Basic Description", Content = "This is my first blog post content.", Tags = new List<string>() { "Intro", "ASP.Net Core", "Blog Post" } };

            return View(post);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}