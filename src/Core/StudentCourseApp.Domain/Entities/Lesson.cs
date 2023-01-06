using StudentCourseApp.Domain.Common;
using StudentCourseApp.Domain.Enums;

namespace StudentCourseApp.Domain.Entities
{
    public class Lesson : BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public LessonLevel LessonLevel { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
