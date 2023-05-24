using System.Collections.Generic;
using SalesNewApp.Models;

namespace SalesNewApp.Services
{
    public class DepartmentService
    {

        private readonly SalesNewAppContext _context;

        public DepartmentService(SalesNewAppContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }


}