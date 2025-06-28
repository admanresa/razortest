using EmployeesCRUD.Models;
using EmployeesCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EmployeesCRUD.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EditModel(IEmployeeRepository employeeRepository)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _employeeRepo.UpdateAsync(Employee);
            return RedirectToPage("Index");
        }
    }
}