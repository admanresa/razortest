using EmployeesCRUD.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeesCRUD.ViewComponents
{
    public class EmployeeStatsViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeStatsViewComponent(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var activeCount = await _repository.GetActiveCountAsync();
            var inactiveCount = await _repository.GetInactiveCountAsync();

            // Pasamos un arreglo con los dos valores
            return View(new[] { activeCount, inactiveCount });
        }
    }
}