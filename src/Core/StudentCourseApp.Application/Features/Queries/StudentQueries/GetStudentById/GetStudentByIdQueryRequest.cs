using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Queries.StudentQueries.GetStudentById
{
    public class GetStudentByIdQueryRequest : IRequest<IResponse<StudentDto>>
    {
        public int Id { get; set; }
    }
}
