using EmployeesCRUD.Models;
using EmployeesCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EmployeesCRUD.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepo;

        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Employee = await _employeeRepo.GetByIdAsync(id);

            if (Employee == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _employeeRepo.DeleteAsync(id);
            return RedirectToPage("Index");
        }
    }
}