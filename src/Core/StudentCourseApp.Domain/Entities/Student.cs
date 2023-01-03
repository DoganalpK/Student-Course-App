using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class Student : BaseEntity
    {
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public int SchoolNumber { get; set; }
        public Guid StudentClassId { get; set; }
        public StudentClass StudentClass { get; set; }
    }
}
