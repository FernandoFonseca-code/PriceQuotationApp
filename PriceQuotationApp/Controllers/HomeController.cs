using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
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
            var calculations = new Calculations();
            return View(calculations);
        }
        [HttpPost]
        public IActionResult Index(Calculations calculations)
        {
            return View(calculations);
        }

        public IActionResult Reset()
        {
            return View("Index", new Calculations());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
