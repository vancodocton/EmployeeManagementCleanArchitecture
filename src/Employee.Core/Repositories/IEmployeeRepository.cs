using Employee.Core.Entities;
using Employee.Core.Interfaces;

namespace Employee.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<SysEmployee>
    {
        Task<IEnumerable<SysEmployee>> GetEmployeeByLastNameAsync(string lastname);
    }
}
