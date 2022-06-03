using Employee.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<SysEmployee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
            Employees = Set<SysEmployee>();
        }
    }
}
