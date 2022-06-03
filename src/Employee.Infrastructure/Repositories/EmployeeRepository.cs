using Employee.Core.Entities;
using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Repositories
{
    internal class EmployeeRepository : RepositoryBase<SysEmployee>, IEmployeeRepository
    {
        private readonly DbSet<SysEmployee> employees;

        public EmployeeRepository(EmployeeDbContext dbContext) : base(dbContext)
        {
            employees = dbContext.Set<SysEmployee>();
        }

        public async Task<IEnumerable<SysEmployee>> GetEmployeeByLastNameAsync(string lastname)
        {
            return await employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}
