using FilterDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [UserLog]
        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1,Name="emp1",Salary=45000},
                new Employee{Id=2,Name="emp1",Salary=45000},
                new Employee{Id=3,Name="emp1",Salary=45000},
                new Employee{Id=4,Name="emp1",Salary=45000},
                new Employee{Id=5,Name="emp1",Salary=45000},
            };
            ViewBag.Employees = employees;  
            return View();
        }
    }
}
