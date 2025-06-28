using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeesCRUD.Models;

namespace EmployeesCRUD.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
        Task<IEnumerable<Employee>> SearchAsync(string searchString, string sortOrder);
        Task<int> GetActiveCountAsync();
        Task<int> GetInactiveCountAsync();
    }
}