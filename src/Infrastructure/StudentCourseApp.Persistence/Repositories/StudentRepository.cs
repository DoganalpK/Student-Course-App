using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Domain.Entities;
using StudentCourseApp.Persistence.Contexts;

namespace StudentCourseApp.Persistence.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
