using EmployeesCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Models assigment

        public DbSet<Employee> Employees { get; set; }
    }
}
