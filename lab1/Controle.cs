using Microsoft.AspNetCore.Mvc;

namespace ApplicationInsightsLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TestError()
        {
            throw new Exception("Тестова помилка");
        }
    }
}