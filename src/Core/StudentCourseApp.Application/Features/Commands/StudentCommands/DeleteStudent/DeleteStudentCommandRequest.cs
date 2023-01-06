using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.DeleteStudent
{
    public class DeleteStudentCommandRequest : IRequest<IResponse>
    {
        public int Id { get; set; }
    }
}
