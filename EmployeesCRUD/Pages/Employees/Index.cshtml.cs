using EmployeesCRUD.Models;
using EmployeesCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesCRUD.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepo;

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }

        public IEnumerable<Employee> Employees { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public async Task OnGetAsync()
        {
            Employees = await _employeeRepo.SearchAsync(SearchString, SortOrder);
        }
    }
}