using Emp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Emp.API.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
