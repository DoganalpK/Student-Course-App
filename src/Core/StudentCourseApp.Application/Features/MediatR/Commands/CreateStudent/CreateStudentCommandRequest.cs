using MediatR;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent
{
    public class CreateStudentCommandRequest : IRequest<IResponse>
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public Guid StudentClassId { get; set; }
    }
}
