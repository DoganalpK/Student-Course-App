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
    public class GetStudentByIdQueryRequest : IRequest<Response<StudentDto>>
    {
        public Guid Id { get; set; }
    }
}
