using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SchoolNumber { get; set; }
        public int StudentClassId { get; set; }
        public StudentClass StudentClass { get; set; }
    }
}
