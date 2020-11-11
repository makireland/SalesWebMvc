using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            var departmentList = new List<Department>();
            departmentList.Add(new Department { Id = 1, Name = "Eletronics"});
            departmentList.Add(new Department { Id = 2, Name = "Fashion" });

            return View(departmentList);
        }
    }
}
