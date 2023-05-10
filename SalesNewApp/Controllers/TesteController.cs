using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using SalesNewApp.Models;
namespace SalesNewApp.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            List<Teste> list = new List<Teste>();
            list.Add(new Teste { Age = 1 ,Name = "antonio"});
            list.Add(new Teste { Age = 2, Name = "karine" });
            return View(list);
        }
    }
}
