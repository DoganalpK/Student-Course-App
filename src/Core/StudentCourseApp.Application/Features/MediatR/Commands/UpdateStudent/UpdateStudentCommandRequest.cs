using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.UpdateStudent
{
    /// <summary>
    /// MediatoR update student request
    /// </summary>
    public class UpdateStudentCommandRequest : IRequest<Response<StudentDto>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
