using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Commands.TeacherCommands.CreateTeacher
{
    public class CreateTeacherCommandRequest : IRequest<IResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
