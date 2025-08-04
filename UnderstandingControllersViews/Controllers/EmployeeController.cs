using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

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
        public IActionResult Detail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Detail(int id , string name )
        {
            Employee emp = new Employee();
            emp.Id = id;
            emp.Name = name;
            emp.Salary = 1000;
            emp.Degignation = "Manager";
            emp.Address = "Bangladesh";
            return View(emp);
        }

       
    }
}
