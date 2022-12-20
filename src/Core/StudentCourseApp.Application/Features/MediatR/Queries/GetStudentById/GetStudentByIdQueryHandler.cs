using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Queries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQueryRequest, Response<StudentDto>>
    {
        public Task<Response<StudentDto>> Handle(GetStudentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
