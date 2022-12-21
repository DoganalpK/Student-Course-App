using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.DeleteStudent
{
    public class DeleteStudentCommandRequest : IRequest<IResponse>
    {
        public Guid Id { get; set; }
    }
}
