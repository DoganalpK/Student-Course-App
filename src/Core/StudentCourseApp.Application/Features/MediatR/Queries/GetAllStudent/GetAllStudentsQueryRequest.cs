using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Queries.GetAllStudent
{
    public class GetAllStudentsQueryRequest : IRequest<Response<List<StudentDto>>>
    {
    }
}
