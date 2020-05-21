using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("First controller action result");
        }
        public IActionResult AnotherAction()
        {
            return Content("Test new method");
        }
    }
}
