using _23Aug.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23Aug.Controllers
{
    public class EmployeeController : Controller
    {
        public static Employee e1 = new Employee();
        public static Employee e2 = new Employee();
        public static List<Employee> emp = new List<Employee>();
        public readonly Employee employee;
        public IActionResult Index()
        {

            var emp = employee.GetEmployee();

            return View(emp);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            emp.Add(e);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var e = emp.SingleOrDefault(s => s.Id == id);
            return View(e);
        }
    }
}
