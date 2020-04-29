using OnlineSalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalesMvc.Services
{
    public class DepartmentService
    {
        private readonly OnlineSalesMvcContext _context;

        public DepartmentService(OnlineSalesMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() 
        {
            return _context.Department.OrderBy(n => n.Name).ToList();
        }
    }
}
