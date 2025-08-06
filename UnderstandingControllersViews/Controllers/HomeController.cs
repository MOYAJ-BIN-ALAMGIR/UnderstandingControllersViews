using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Controllers
{
    using AspNetCoreGeneratedDocument;
    using Microsoft.Extensions.Hosting.Internal;
    using UnderstandingControllersViews.Models;
    public class HomeController : Controller
    {
        private IWebHostEnvironment hostingEnvironment;
        public HomeController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index (IFormFile photo)
        {
            using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, photo.FileName),FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }
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

        public IActionResult CallSharedView()
        {
            return View();
        }
    }
}
