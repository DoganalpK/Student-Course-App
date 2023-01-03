using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Queries.GetAllStudents
{
    public class GetAllStudentsQueryRequest : IRequest<IResponse<List<StudentDto>>>
    {
    }
}
