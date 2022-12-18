using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Queries.StudentQ
{
    public class GetStudentByIdQuery : IRequest<ServiceResponse<StudentDto>>
    {
        public Guid Id { get; set; }

        public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, ServiceResponse<StudentDto>>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;

            public GetStudentByIdQueryHandler(IStudentRepository studentRepository, IMapper mapper)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<StudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
            {
                var student = await _studentRepository.GetByIdAsync(request.Id);
                var dto = _mapper.Map<StudentDto>(student);
                return new ServiceResponse<StudentDto>(dto);
            }
        }
    }
}
