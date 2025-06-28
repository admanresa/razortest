using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesCRUD.Models;
using EmployeesCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeesCRUD.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await GetByIdAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> SearchAsync(string searchString, string sortOrder)
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(e => e.Name.Contains(searchString) ||
                                         e.Email.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    query = query.OrderByDescending(e => e.Name);
                    break;
                case "email_asc":
                    query = query.OrderBy(e => e.Email);
                    break;
                case "email_desc":
                    query = query.OrderByDescending(e => e.Email);
                    break;
                case "date_asc":
                    query = query.OrderBy(e => e.EntryDate);
                    break;
                case "date_desc":
                    query = query.OrderByDescending(e => e.EntryDate);
                    break;
                default:
                    query = query.OrderBy(e => e.Name); // Orden predeterminado
                    break;
            }

            return await query.ToListAsync();
        }

        public async Task<int> GetActiveCountAsync()
        {
            return await _context.Employees.CountAsync(e => e.IsActive);
        }

        public async Task<int> GetInactiveCountAsync()
        {
            return await _context.Employees.CountAsync(e => !e.IsActive);
        }
    }
}