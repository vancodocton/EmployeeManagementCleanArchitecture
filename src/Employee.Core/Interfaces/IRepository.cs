namespace Employee.Core.Interfaces
{
    public interface IRepository<T> : IReadRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
