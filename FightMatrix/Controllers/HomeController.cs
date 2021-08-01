using Microsoft.AspNetCore.Mvc;

namespace FightMatrix.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
