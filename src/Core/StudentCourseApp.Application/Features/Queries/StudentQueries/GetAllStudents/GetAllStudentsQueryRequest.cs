using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Queries.StudentQueries.GetAllStudents
{
    public class GetAllStudentsQueryRequest : IRequest<IResponse<List<StudentDto>>>
    {
    }
}
