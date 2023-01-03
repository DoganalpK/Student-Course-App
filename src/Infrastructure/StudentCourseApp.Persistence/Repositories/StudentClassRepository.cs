using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Domain.Entities;
using StudentCourseApp.Persistence.Contexts;

namespace StudentCourseApp.Persistence.Repositories
{
    public class StudentClassRepository : GenericRepository<StudentClass>, IStudentClassRepository
    {
        private readonly AppDbContext _context;
        public StudentClassRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
