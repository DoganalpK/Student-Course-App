using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
