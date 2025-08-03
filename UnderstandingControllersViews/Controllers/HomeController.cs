using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Controllers
{
    using AspNetCoreGeneratedDocument;
    using UnderstandingControllersViews.Models;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReceivedDataByParameter(string name, string sex)
        {
            return View("ReceivedDataByParameter", $"{name} sex is {sex}");
        }
        public IActionResult ReceivedDataByRequest()
        {
            string name = Request.Form["name"];
            string sex = Request.Form["sex"];
            return View("ReceivedDataByRequest", $"{name} sex is {sex}");
        }
        public IActionResult ReceivedDataByModelBinding (Person person)
        {
            return View("ReceivedDataByModelBinding", person);
        }
    }
}
