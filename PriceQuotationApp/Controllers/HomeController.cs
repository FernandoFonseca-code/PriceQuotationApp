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
        [HttpGet]
        public IActionResult Index()
        {
            var model = new Calculations();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Calculations model)
        {
            return View(model);
        }

        public IActionResult Reset()
        {
            var model = new Calculations();
            return View("Index", model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
