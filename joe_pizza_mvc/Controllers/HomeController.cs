using Microsoft.AspNetCore.Mvc;
using joe_pizza_mvc.Models;
using System.Diagnostics;

namespace joe_pizza_mvc.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult pizza1view()
        {
            return View();
        }

        public IActionResult pizza2view()
        {
            return View();
        }

        public IActionResult pizza3view()
        {
            return View();
        }

        public IActionResult pizza4view()
        {
            return View();
        }

        public IActionResult pizza5view()
        {
            return View();
        }

        public IActionResult orderconfirmed()
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