using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "Hello World!";
        }
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }
        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }
        //public IActionResult Index3()
        //{
        //    return Content("Employee");
        //}
        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee() {ID=1,FirstName="Gökhan",LastName="Gök",Age=23},
                new Employee() {ID=2,FirstName="Can",LastName="Dağ",Age=20},
                new Employee() {ID=3,FirstName="Demir",LastName="Güneş",Age=37},
            };
            return View("Index3", list);
        }
    }
}
