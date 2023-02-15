using Microsoft.AspNetCore.Mvc;

namespace WEB_1001_Winter_2023_Web_App_101.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
