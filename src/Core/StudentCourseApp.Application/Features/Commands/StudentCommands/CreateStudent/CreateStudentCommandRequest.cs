using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentCommandRequest : IRequest<IResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentClassId { get; set; }
    }
}
