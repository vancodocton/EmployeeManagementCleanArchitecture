namespace Employee.Core.Interfaces
{
    public interface IReadRepository<T> : IDisposable where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int id);
    }
}
