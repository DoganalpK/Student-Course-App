using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Queries.GetAllStudent
{
    public class GetAllStudentsQueryRequest : IRequest<IResponse<List<StudentDto>>>
    {
    }
}
