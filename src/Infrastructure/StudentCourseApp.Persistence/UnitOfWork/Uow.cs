using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Interfaces.UnitOfWork;
using StudentCourseApp.Domain.Common;
using StudentCourseApp.Persistence.Contexts;
using StudentCourseApp.Persistence.Repositories;

namespace StudentCourseApp.Persistence.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;

        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
