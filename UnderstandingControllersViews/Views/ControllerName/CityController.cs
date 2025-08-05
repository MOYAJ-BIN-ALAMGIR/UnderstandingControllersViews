using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Views.ControllerName
{
    public class CityController : Controller
    {
        public IActionResult NewYork()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
