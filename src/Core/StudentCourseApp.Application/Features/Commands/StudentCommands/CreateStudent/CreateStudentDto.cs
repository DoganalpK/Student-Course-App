namespace StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SchoolNumber { get; set; }
        public int StudentClassId { get; set; }
    }
}
