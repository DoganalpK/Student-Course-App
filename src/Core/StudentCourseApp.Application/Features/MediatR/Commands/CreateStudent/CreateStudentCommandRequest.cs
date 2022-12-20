using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent
{
    public class CreateStudentCommandRequest : IRequest<IResponse<StudentDto>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
