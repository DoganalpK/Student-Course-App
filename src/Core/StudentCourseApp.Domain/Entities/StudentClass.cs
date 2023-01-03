﻿using StudentCourseApp.Domain.Common;

namespace StudentCourseApp.Domain.Entities
{
    public class StudentClass:BaseEntity
    {
        public int ClassNumber { get; set; }
        public String ClassLetter { get; set; }
        public List<Student> Students { get; set; }
    }
}