using ASP_Lecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Lecture.Controllers
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
            ViewData["Name"] = "Omar Abdulla";
            ViewBag.Age = 34;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        //public IActionResult Result(string CatName, int CatAge)
        //{
        //    ViewData["CatName"] = CatName;
        //    ViewData["CatAge"] = CatAge;
        //    return View();
        //}

        public IActionResult Result(Cat c)
        {
            return View(c);
        }
        public IActionResult Privacy()
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