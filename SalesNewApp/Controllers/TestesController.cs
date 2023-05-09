using Microsoft.AspNetCore.Mvc;
using SalesNewApp.Models;

namespace SalesNewApp.Controllers
{
    public class TestesController : Controller
    {
        public IActionResult Index()
        {

            List<Teste> list = new List<Teste>();
            list.Add(new Teste { Name = "antonio", Age = 23,Email = "antonioguilhermemc@gmail.com" });
            list.Add(new Teste { Name = "karine", Age = 22,Email = "karineneriscsm@gmail.com" });
            return View(list);
        }
    }
}
