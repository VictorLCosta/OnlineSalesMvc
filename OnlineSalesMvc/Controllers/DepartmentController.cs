using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSalesMvc.Models;

namespace OnlineSalesMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1, "Eletronics"));
            departments.Add(new Department(2, "Fashion"));

            return View(departments);
        }
    }
}