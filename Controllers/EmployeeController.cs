using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {

        static List<Employee> employees = [

        new Employee { FirstName = "Noura", LastName = "Aldaihani", EmployeeId = "83333", Department = "IT", Email = "noura@gmail.com" },
            new Employee { FirstName = "Noura", LastName = "Aldaihani", EmployeeId = "83333", Department = "IT", Email = "noura@gmail.com" }
         ];

        public IActionResult Index()
        {
            return View(employees);
        }

        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Register(AddEmployeeForm form)
        {
            if (ModelState.IsValid) {

                var EmployeeId = form.EmployeeId;
                var FirstName = form.FirstName;
                var LastName = form.LastName;
                var Email = form.Email;
                var Department = form.Department;
                employees.Add(new Employee { EmployeeId = EmployeeId, FirstName = FirstName, LastName = LastName, Department = Department, Email = Email });

                return RedirectToAction("Index");
            }
                return View(form);
        }
    }
}
