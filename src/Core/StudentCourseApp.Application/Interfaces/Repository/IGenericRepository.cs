using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity, T unchanged);
        Task RemoveAsync(object id);
    }
}
