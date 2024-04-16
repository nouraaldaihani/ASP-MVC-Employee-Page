using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            { 
                new Employee { FirstName = "Noura", LastName = "Aldaihani", EmployeeId = 83333, Department = "IT", Email = "noura@gmail.com" }
                };
            return View(employees);
        }
    }
}
