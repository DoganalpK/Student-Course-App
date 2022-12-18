using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
