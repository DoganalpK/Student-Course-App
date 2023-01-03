using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudentClass
{
    public class CreateStudentClassCommandRequest : IRequest<IResponse>
    {
        public int ClassNumber { get; set; }
        public String ClassLetter { get; set; }
    }
}
