using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}