using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalesNewApp.Models;
using SalesNewApp.Models.ViewModels;
using System.Diagnostics;

namespace SalesNewApp.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }
        Teste teste = new Teste();

        public IActionResult Index() {
            ViewData["Email"] = "antonioguilhermemc@gmail.com";
            ViewData["name"] = "Antonio Guilherme";
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}