using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_Store.Models;

namespace Web_Store.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees= new Employee() { 

        }

        public IActionResult EmployeeDatails(int id)
        {
            var employee = _Employees.FirstOrDefault(x => x.Id == id);
            if (employee is null) return NotFound();
        }
        public IActionResult Index()
        {
        ViewBag.title = "Hello world";
            return View(_Employees);
        }
        public IActionResult AnotherAction()
        {
            return Content("Test new method");
        }
    }
}
