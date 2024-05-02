using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            return View();
        }
        public IActionResult Page1()
        {
            return View("Page1");
        }
        [HttpPost]
        public IActionResult Page1(ClientInfo model)
        {
            return RedirectToAction("Page2");
        }

        public IActionResult Page2()
        {
            return View("Page2");
        }
        [HttpPost]

        public IActionResult Page2(Marketing model)
        {
            return RedirectToAction("Page3");
        }

        public IActionResult Page3()
        {
            return View("Page3");
        }
        [HttpPost]
        public IActionResult Page3(Shipping model)
        {
            return RedirectToAction("Page4");
        }

        public IActionResult Page4()
        {
            return View("Page4");
        }
        [HttpPost]

        public IActionResult Page4(Pricing model)
        {
            return RedirectToAction("Page5");
        }

        public IActionResult Page5()
        {
            return View("Page5");
        }
        [HttpPost]

        public IActionResult Page5(EasyWeb model)
        {
            return RedirectToAction("Page6");
        }
        public IActionResult Page6()
        {
            return View("Page6");
        }
        [HttpPost]

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