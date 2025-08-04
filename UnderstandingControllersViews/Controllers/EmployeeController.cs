using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id, string name)
        {
            string welcomeMessage = $"Welcome Employee: {name} with id :{id}";
            return View((object)welcomeMessage);
        }
    }
}
