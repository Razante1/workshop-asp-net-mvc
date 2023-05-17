using Microsoft.AspNetCore.Mvc;

namespace SalesNewApp.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
