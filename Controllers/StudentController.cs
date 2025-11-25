using Microsoft.AspNetCore.Mvc;
using Apetrei_Alexandru_Lab1.Models;

namespace Apetrei_Alexandru_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
