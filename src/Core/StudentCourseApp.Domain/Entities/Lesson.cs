using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public int LessonDay { get; set; }
        public int LessonPeriod { get; set; }
    }
}
