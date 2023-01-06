using Microsoft.EntityFrameworkCore;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Domain.Common;
using StudentCourseApp.Persistence.Contexts;

namespace StudentCourseApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(object id)
        {
            var data = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity, T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
        }
    }
}
