using Microsoft.AspNetCore.Mvc;

namespace mvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}