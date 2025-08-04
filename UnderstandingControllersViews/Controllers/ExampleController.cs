using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewBagExample()
        {
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.CurrentYear = DateTime.Now.Year;
            return View();
        }

        public IActionResult TempDataExample()
        {
            TempData["CurrentDateTime"] = DateTime.Now;
            TempData["CurrentYear"] = DateTime.Now.Year;
            return RedirectToAction("TempDataShow");
        }
        public IActionResult TempDataShow()
        {
            return View();
        }
        
        public IActionResult SessionExample()
        {
            HttpContext.Session.SetString("CurrentDateTime", DateTime.Now.ToString());
            HttpContext.Session.SetInt32("CurrentYear", DateTime.Now.Year);
            return View();
        }
    }
}
