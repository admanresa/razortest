using EmployeesCRUD.Models;
using EmployeesCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EmployeesCRUD.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepo;

        public CreateModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _employeeRepo.AddAsync(Employee);
            return RedirectToPage("Index");
        }
    }
}